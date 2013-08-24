using System;
using System.Globalization;
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

namespace D3EHPCalculator
{
    public partial class Form1 : Form
    {

        //Declare Variables
        private String _profileUrl;
        private String _heroUrl;
        private String _heroclass;
        private double _lowestresistance;
        private int _herototallife;
        private int _heroarmor;
        private int _enemylevel;
        private int _enemydamage;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to search for a profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Click(object sender, EventArgs e)
        {
            if (profileBox.Text != "" || codeBox.Text != "")
            {
                if (regionBox.Text != "")
                {
                    //Download the correct URL for the region, character, code combination.
                    _profileUrl = "http://" + regionBox.Text + ".battle.net/api/d3/profile/" + profileBox.Text + "-" + codeBox.Text + "/";
                    ParseProfile(DownloadFile(_profileUrl));

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
        private void Button2Click(object sender, EventArgs e)
        {
            if (_profileUrl != null)
            {
                if (charselectBox.Text != "")
                {
                    _heroUrl = 
                        "http://" + regionBox.Text + ".battle.net/api/d3/profile/" + 
                        profileBox.Text + "-" + codeBox.Text + "/hero/" + 
                        charselectBox.Text.Remove(charselectBox.Text.IndexOf(" ", System.StringComparison.Ordinal), 
                        charselectBox.Text.Length - charselectBox.Text.IndexOf(" ", System.StringComparison.Ordinal));
                    ParseHero(DownloadFile(_heroUrl));
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
        private void CalculateEhpButtonClick(object sender, EventArgs e)
        {
            CalculateEhp();
        }

        /// <summary>
        /// Download provided URL and return as String
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private String DownloadFile(String url) {
            var webReqeust = new WebClient();
            String webPage = webReqeust.DownloadString(url);
            return webPage;
        }

        /// <summary>
        /// Run the Profile info through a JSON deserializer
        /// </summary>
        /// <param name="profile"></param>
        private void ParseProfile(String profile)
        {
            //If the provided URL returned an invalid Profile Page its JSON will be very short. (~60-70 Characters)
            if (profile.Length < 100)
            {
                MessageBox.Show("The information provided did not return a valid Battle.Net Account.");
            }
            else
            {
                var profileJson = new JavaScriptSerializer().Deserialize<ProfileJSON>(profile);

                //Add the newly parsed Heroes to the Hero ComboBox
                foreach (Hero t in profileJson.heroes)
                {
                    charselectBox.Items.Add(t.id + " - " + t.name + " - " + t.level + " - " + t.@class);
                }
            }
        }

        /// <summary>
        /// Run the Character info through a JSON deserializer
        /// </summary>
        /// <param name="hero"></param>
        private void ParseHero(String hero)
        {
            var heroJson = new JavaScriptSerializer().Deserialize<HeroJSON>(hero);
            PopulateGui(heroJson);
        }

        /// <summary>
        /// Fill in the GUI with the newly parsed information
        /// </summary>
        /// <param name="heroJson"></param>
        private void PopulateGui(HeroJSON heroJson)
        {
            _heroclass = heroJson.@class;
            classBox.Text = _heroclass;
            levelBox.Text = heroJson.level.ToString(CultureInfo.InvariantCulture);
            strengthBox.Text = heroJson.stats.strength.ToString(CultureInfo.InvariantCulture);
            dexterityBox.Text = heroJson.stats.dexterity.ToString(CultureInfo.InvariantCulture);
            intelligenceBox.Text = heroJson.stats.intelligence.ToString(CultureInfo.InvariantCulture);
            vitalityBox.Text = heroJson.stats.vitality.ToString(CultureInfo.InvariantCulture);
            _herototallife = heroJson.stats.life;
            lifeBox.Text = _herototallife.ToString(CultureInfo.InvariantCulture);
            _heroarmor = heroJson.stats.armor;
            armorBox.Text = _heroarmor.ToString(CultureInfo.InvariantCulture);

            //Next fill in information that takes extra manual calculations:

            //If the player is below level 60 compare the EHP to mobs of their level
            //Otherwise if they are level 60 compare them to the highest level mobs (63)
            if (heroJson.level < 60)
            {
                _enemylevel = heroJson.level;
                _enemydamage = _enemylevel * 500; //Rough estimate for sub-max level damage
            }
            else
            {
                _enemylevel = 63;
                _enemydamage = 70000; //Average damage of monsters in Infero Act 2-3
            }

            enemylevelBox.Text = _enemylevel.ToString(CultureInfo.InvariantCulture);
            enemyrawdamageBox.Text = _enemydamage.ToString(CultureInfo.InvariantCulture);

            //Resist All is calculated as your lowest resist:
            int[] resistList = { heroJson.stats.arcaneResist, 
                             heroJson.stats.coldResist,
                             heroJson.stats.fireResist, 
                             heroJson.stats.lightningResist, 
                             heroJson.stats.physicalResist, 
                             heroJson.stats.poisonResist, 
                             heroJson.stats.coldResist};
            Array.Sort(resistList);
            _lowestresistance = resistList[0];
            resistallBox.Text = _lowestresistance.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Calculate Effective Health Points
        /// </summary>
        private void CalculateEhp()
        {
            //Calculate Armor Mitigation:
            double armormitigation = (double) _heroarmor / ( _heroarmor + _enemylevel * 50);

            //Calculate Resistance Migitgation:
            double resistancemitigation = _lowestresistance / (_lowestresistance + _enemylevel * 5);

            //Calculate Passive Class Mitigation: 
            //Barbarian/Monk both receive a passive 30% mitigation
            double passivemitigation;
            if (_heroclass.Equals("barbarian") || _heroclass.Equals("monk"))
            {
                passivemitigation = 0.3;
            }
            else
            {
                passivemitigation = 0.0;
            }

            //Calculate Total Mitigation as a sum of mitigation from all types
            double totalmitigation = 100 * ((1 - (1 - armormitigation) * (1 - resistancemitigation) * (1 - passivemitigation)));

            //Calculate Mitigated Damage:
            //How much of the raw damage is being mitigated and not dealt
            double mitigateddamage = _enemydamage - (_enemydamage * (totalmitigation / 100));

            //How many hits from this non mitigated damage would it take to use up the players health:
            double hitstodie = _herototallife / mitigateddamage;

            //Effective health is now the raw damage multiplied by the number of hits needed to die:
            double effectivehealth = hitstodie * _enemydamage;
            effectiveHPBox.Text = effectivehealth.ToString();
        }
    }
}
