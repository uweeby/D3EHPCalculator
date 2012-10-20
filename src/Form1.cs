using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Net;

/* Project: D3 EHP Calculator
 * 
 * Resources:
 * Blizzard API: http://blizzard.github.com/d3-api-docs/#
 * JSON Class Wrapper: http://json2csharp.com/
 * 
 * Contact: uweenukr@gmail.com
 * 
 * Overview: This tool will calculate the Effective Health Pool for a given D3 Hero Profile.
 * Profile/Hero information is downloaded from the Blizzard API site in the form of JSON.
 */

namespace uweenukr
{
    public partial class Form1 : Form
    {

        //Declare Variables
        private String ProfileURL;
        private String HeroURL;
        private String heroclass;
        private double lowestresistance;
        private int herototallife;
        private int heroarmor;
        private int enemylevel;
        private int enemydamage;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to search for a profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if (profileBox.Text != "" || codeBox.Text != "")
            {
                if (regionBox.Text != "")
                {
                    //Download the correct URL for the region, character, code combination.
                    ProfileURL = "http://" + regionBox.Text + ".battle.net/api/d3/profile/" + profileBox.Text + "-" + codeBox.Text + "/";
                    ParseProfile(DownloadFile(ProfileURL));

                }
                else
                {
                    MessageBox.Show("Please Enter a valid [Character Name] [Character Code] and [Region]");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid [Character Name] [Character Code] and [Region]");
            }

        }

        /// <summary>
        /// Button to select Character from Profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            if (ProfileURL != null)
            {
                if (charselectBox.Text != "")
                {
                    HeroURL = "http://" + regionBox.Text + ".battle.net/api/d3/profile/" + profileBox.Text + "-" + codeBox.Text + "/hero/" + charselectBox.Text.Remove(charselectBox.Text.IndexOf(" "), charselectBox.Text.Length - charselectBox.Text.IndexOf(" "));
                    ParseHero(DownloadFile(HeroURL));
                }
                else
                {
                    MessageBox.Show("Please Select a Character from the Drop Down");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid [Character Name] [Character Code] and [Region]");
            }
        }

        /// <summary>
        /// Calculate Selected Hero EHP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateEHPButton_Click(object sender, EventArgs e)
        {
            CalculateEHP();
        }

        /// <summary>
        /// Download provided URL and return as String
        /// </summary>
        /// <param name="_URL"></param>
        /// <returns></returns>
        private String DownloadFile(String _URL) {
            WebClient WebReqeust = new WebClient();
            String WebPage = WebReqeust.DownloadString(_URL);
            return WebPage;
        }

        /// <summary>
        /// Run the Profile info through a JSON deserializer
        /// </summary>
        /// <param name="_Profile"></param>
        private void ParseProfile(String _Profile)
        {
            //If the provided URL returned an invalid Profile Page its JSON will be very short. (~60-70 Characters)
            if (_Profile.Length < 100)
            {
                MessageBox.Show("The information provided did not return a valid Battle.Net Account.");
            }
            else
            {
                ProfileJSON profileJSON = new JavaScriptSerializer().Deserialize<ProfileJSON>(_Profile);

                //Add the newly parsed Heroes to the Hero ComboBox
                for (int i = 0; i < profileJSON.heroes.Count; i++)
                {
                    charselectBox.Items.Add(profileJSON.heroes[i].id + " - " + profileJSON.heroes[i].name + " - " + profileJSON.heroes[i].level + " - " + profileJSON.heroes[i].@class);
                }
            }
        }

        /// <summary>
        /// Run the Character info through a JSON deserializer
        /// </summary>
        /// <param name="_Hero"></param>
        private void ParseHero(String _Hero)
        {
            HeroJSON heroJSON = new JavaScriptSerializer().Deserialize<HeroJSON>(_Hero);
            PopulateGUI(heroJSON);
        }

        /// <summary>
        /// Fill in the GUI with the newly parsed information
        /// </summary>
        /// <param name="_heroJSON"></param>
        private void PopulateGUI(HeroJSON _heroJSON)
        {
            heroclass = _heroJSON.@class;
            classBox.Text = heroclass;
            levelBox.Text = _heroJSON.level.ToString();
            strengthBox.Text = _heroJSON.stats.strength.ToString();
            dexterityBox.Text = _heroJSON.stats.dexterity.ToString();
            intelligenceBox.Text = _heroJSON.stats.intelligence.ToString();
            vitalityBox.Text = _heroJSON.stats.vitality.ToString();
            herototallife = _heroJSON.stats.life;
            lifeBox.Text = herototallife.ToString();
            heroarmor = _heroJSON.stats.armor;
            armorBox.Text = heroarmor.ToString();

            //Next fill in information that takes extra manual calculations:

            //If the player is below level 60 compare the EHP to mobs of their level
            //Otherwise if they are level 60 compare them to the highest level mobs (63)
            if (_heroJSON.level < 60)
            {
                enemylevel = _heroJSON.level;
                enemydamage = enemylevel * 500; //Rough estimate for sub-max level damage
            }
            else
            {
                enemylevel = 63;
                enemydamage = 70000; //Average damage of monsters in Infero Act 2-3
            }

            enemylevelBox.Text = enemylevel.ToString();
            enemyrawdamageBox.Text = enemydamage.ToString();

            //Resist All is calculated as your lowest resist:
            int[] resistList = { _heroJSON.stats.arcaneResist, 
                             _heroJSON.stats.coldResist,
                             _heroJSON.stats.fireResist, 
                             _heroJSON.stats.lightningResist, 
                             _heroJSON.stats.physicalResist, 
                             _heroJSON.stats.poisonResist, 
                             _heroJSON.stats.coldResist};
            Array.Sort(resistList);
            lowestresistance = resistList[0];
            resistallBox.Text = lowestresistance.ToString();
        }

        /// <summary>
        /// Calculate Effective Health Points
        /// </summary>
        private void CalculateEHP()
        {
            double armormitigation; 
            double resistancemitigation; 
            double totalmitigation;
            double passivemitigation;
            double mitigateddamage;
            double hitstodie;
            double effectivehealth;

            //Calculate Armor Mitigation:
            armormitigation =  (double) heroarmor / ( heroarmor + enemylevel * 50);

            //Calculate Resistance Migitgation:
            resistancemitigation = lowestresistance / (lowestresistance + enemylevel * 5);

            //Calculate Passive Class Mitigation: 
            //Barbarian/Monk both receive a passive 30% mitigation
            if (heroclass.Equals("barbarian") || heroclass.Equals("monk"))
            {
                passivemitigation = 0.3;
            }
            else
            {
                passivemitigation = 0.0;
            }

            //Calculate Total Mitigation as a sum of mitigation from all types
            totalmitigation = 100 * ((1 - (1 - armormitigation) * (1 - resistancemitigation) * (1 - passivemitigation)));

            //Calculate Mitigated Damage:
            //How much of the raw damage is being mitigated and not dealt
            mitigateddamage = enemydamage - (enemydamage * (totalmitigation / 100));

            //How many hits from this non mitigated damage would it take to use up the players health:
            hitstodie = herototallife / mitigateddamage;

            //Effective health is now the raw damage multiplied by the number of hits needed to die:
            effectivehealth = hitstodie * enemydamage;
            effectiveHPBox.Text = effectivehealth.ToString();
        }
    }
}
