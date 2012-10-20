using System.Collections.Generic;

/* JSON Wrapper Class to handle data from Blizzard D3 API
 * Doc: http://blizzard.github.com/d3-api-docs/#hero-profile/hero-profile-example
 * 
 * Class Document made from: http://json2csharp.com/
 * 
 */

namespace uweenukr
{
    public class Skill
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int level { get; set; }
        public string categorySlug { get; set; }
        public string tooltipUrl { get; set; }
        public string description { get; set; }
        public string simpleDescription { get; set; }
        public string skillCalcId { get; set; }
    }

    public class Rune
    {
        public string slug { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public string description { get; set; }
        public string simpleDescription { get; set; }
        public string tooltipParams { get; set; }
        public string skillCalcId { get; set; }
        public int order { get; set; }
    }

    public class Active
    {
        public Skill skill { get; set; }
        public Rune rune { get; set; }
    }

    public class Skill2
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string tooltipUrl { get; set; }
        public string description { get; set; }
        public string flavor { get; set; }
        public string skillCalcId { get; set; }
        public int level { get; set; }
    }

    public class Passive
    {
        public Skill2 skill { get; set; }
    }

    public class Skills
    {
        public List<Active> active { get; set; }
        public List<Passive> passive { get; set; }
    }

    public class Head
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Torso
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Feet
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Hands
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Shoulders
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Legs
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Bracers
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class MainHand
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class OffHand
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Waist
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class RightFinger
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class LeftFinger
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Neck
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Items
    {
        public Head head { get; set; }
        public Torso torso { get; set; }
        public Feet feet { get; set; }
        public Hands hands { get; set; }
        public Shoulders shoulders { get; set; }
        public Legs legs { get; set; }
        public Bracers bracers { get; set; }
        public MainHand mainHand { get; set; }
        public OffHand offHand { get; set; }
        public Waist waist { get; set; }
        public RightFinger rightFinger { get; set; }
        public LeftFinger leftFinger { get; set; }
        public Neck neck { get; set; }
    }

    public class Special
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class MainHand2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class OffHand2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Items2
    {
        public Special special { get; set; }
        public MainHand2 mainHand { get; set; }
        public OffHand2 offHand { get; set; }
    }

    public class HeroStats
    {
        public int goldFind { get; set; }
        public int magicFind { get; set; }
        public int experienceBonus { get; set; }
    }

    public class Skill4
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int level { get; set; }
        public string tooltipUrl { get; set; }
        public string description { get; set; }
        public string simpleDescription { get; set; }
        public string skillCalcId { get; set; }
    }

    public class Skill3
    {
        public Skill4 skill { get; set; }
    }

    public class Templar
    {
        public string slug { get; set; }
        public int level { get; set; }
        public Items2 items { get; set; }
        public Stats stats { get; set; }
        public List<Skill3> skills { get; set; }
    }

    public class Special2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class MainHand3
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class RightFinger2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class LeftFinger2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Neck2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Items3
    {
        public Special2 special { get; set; }
        public MainHand3 mainHand { get; set; }
        public RightFinger2 rightFinger { get; set; }
        public LeftFinger2 leftFinger { get; set; }
        public Neck2 neck { get; set; }
    }

    public class Stats2
    {
        public int goldFind { get; set; }
        public int magicFind { get; set; }
        public int experienceBonus { get; set; }
    }

    public class Skill6
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int level { get; set; }
        public string tooltipUrl { get; set; }
        public string description { get; set; }
        public string simpleDescription { get; set; }
        public string skillCalcId { get; set; }
    }

    public class Skill5
    {
        public Skill6 skill { get; set; }
    }

    public class Enchantress
    {
        public string slug { get; set; }
        public int level { get; set; }
        public Items3 items { get; set; }
        public Stats2 stats { get; set; }
        public List<Skill5> skills { get; set; }
    }

    public class Followers
    {
        public Templar templar { get; set; }
        public Enchantress enchantress { get; set; }
    }

    public class Stats3
    {
        public int life { get; set; }
        public double damage { get; set; }
        public double attackSpeed { get; set; }
        public int armor { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int vitality { get; set; }
        public int intelligence { get; set; }
        public int physicalResist { get; set; }
        public int fireResist { get; set; }
        public int coldResist { get; set; }
        public int lightningResist { get; set; }
        public int poisonResist { get; set; }
        public int arcaneResist { get; set; }
        public double critDamage { get; set; }
        public double damageIncrease { get; set; }
        public double critChance { get; set; }
        public double damageReduction { get; set; }
        public double blockChance { get; set; }
        public double thorns { get; set; }
        public double lifeSteal { get; set; }
        public double lifePerKill { get; set; }
        public double goldFind { get; set; }
        public double magicFind { get; set; }
        public int blockAmountMin { get; set; }
        public int blockAmountMax { get; set; }
        public double lifeOnHit { get; set; }
        public int primaryResource { get; set; }
        public int secondaryResource { get; set; }
    }

    public class HeroKills
    {
        public int elites { get; set; }
    }

    public class HeroAct1
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class HeroCompletedQuest
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct2
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest> completedQuests { get; set; }
    }

    public class HeroCompletedQuest2
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct3
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest2> completedQuests { get; set; }
    }

    public class HeroCompletedQuest3
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct4
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest3> completedQuests { get; set; }
    }

    public class HeroNormal
    {
        public HeroAct1 act1 { get; set; }
        public HeroAct2 act2 { get; set; }
        public HeroAct3 act3 { get; set; }
        public HeroAct4 act4 { get; set; }
    }

    public class HeroCompletedQuest4
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct12
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest4> completedQuests { get; set; }
    }

    public class HeroCompletedQuest5
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct22
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest5> completedQuests { get; set; }
    }

    public class HeroCompletedQuest6
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct32
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest6> completedQuests { get; set; }
    }

    public class HeroCompletedQuest7
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct42
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest7> completedQuests { get; set; }
    }

    public class HeroNightmare
    {
        public HeroAct12 act1 { get; set; }
        public HeroAct22 act2 { get; set; }
        public HeroAct32 act3 { get; set; }
        public HeroAct42 act4 { get; set; }
    }

    public class HeroAct13
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class HeroCompletedQuest8
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct23
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest8> completedQuests { get; set; }
    }

    public class HeroCompletedQuest9
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct33
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest9> completedQuests { get; set; }
    }

    public class HeroCompletedQuest10
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class HeroAct43
    {
        public bool completed { get; set; }
        public List<HeroCompletedQuest10> completedQuests { get; set; }
    }

    public class HeroHell
    {
        public HeroAct13 act1 { get; set; }
        public HeroAct23 act2 { get; set; }
        public HeroAct33 act3 { get; set; }
        public HeroAct43 act4 { get; set; }
    }

    public class HeroAct14
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class HeroAct24
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class HeroAct34
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class HeroAct44
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class HeroInferno
    {
        public HeroAct14 act1 { get; set; }
        public HeroAct24 act2 { get; set; }
        public HeroAct34 act3 { get; set; }
        public HeroAct44 act4 { get; set; }
    }

    public class Progress
    {
        public Normal normal { get; set; }
        public Nightmare nightmare { get; set; }
        public Hell hell { get; set; }
        public Inferno inferno { get; set; }
    }

    public class HeroJSON
    {
        public int id { get; set; }
        public string name { get; set; }
        public string @class { get; set; }
        public int gender { get; set; }
        public int level { get; set; }
        public int paragonLevel { get; set; }
        public bool hardcore { get; set; }
        public Skills skills { get; set; }
        public Items items { get; set; }
        public Followers followers { get; set; }
        public Stats3 stats { get; set; }
        public Kills kills { get; set; }
        public Progress progress { get; set; }
        public bool dead { get; set; }
        public int last_updated { get; set; }
    }
}
