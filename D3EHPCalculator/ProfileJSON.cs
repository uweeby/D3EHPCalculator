using System.Collections.Generic;

/* JSON Wrapper Class to handle data from Blizzard D3 API
 * Doc: http://blizzard.github.com/d3-api-docs/#career-profile/career-profile-example
 * 
 * Class Document made from: http://json2csharp.com/
 * 
 */

namespace D3EHPCalculator
{
    public class Hero
    {
        public string name { get; set; }
        public int id { get; set; }
        public int level { get; set; }
        public bool hardcore { get; set; }
        public int paragonLevel { get; set; }
        public int gender { get; set; }
        public bool dead { get; set; }
        public string @class { get; set; }
        public int last_updated { get; set; }
    }

    public class Artisan
    {
        public string slug { get; set; }
        public int level { get; set; }
        public int stepCurrent { get; set; }
        public int stepMax { get; set; }
    }

    public class HardcoreArtisan
    {
        public string slug { get; set; }
        public int level { get; set; }
        public int stepCurrent { get; set; }
        public int stepMax { get; set; }
    }

    public class Kills
    {
        public int monsters { get; set; }
        public int elites { get; set; }
        public int hardcoreMonsters { get; set; }
    }

    public class TimePlayed
    {
        public double barbarian { get; set; }
        public double demon_hunter { get; set; }
        public double monk { get; set; }
        public double witch_doctor { get; set; }
        public double wizard { get; set; }
    }

    public class Stats
    {
        public int life { get; set; }
        public double damage { get; set; }
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
        public double damageIncrease { get; set; }
        public double critChance { get; set; }
        public double damageReduction { get; set; }
    }

    public class Kills2
    {
        public int elites { get; set; }
    }

    public class Death
    {
        public int killer { get; set; }
        public int location { get; set; }
        public int time { get; set; }
    }

    public class FallenHero
    {
        public Stats stats { get; set; }
        public Kills2 kills { get; set; }
        public Items items { get; set; }
        public Death death { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public bool hardcore { get; set; }
        public int heroId { get; set; }
        public int gender { get; set; }
        public string @class { get; set; }
    }

    public class CompletedQuest
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act1
    {
        public bool completed { get; set; }
        public List<CompletedQuest> completedQuests { get; set; }
    }

    public class CompletedQuest2
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act2
    {
        public bool completed { get; set; }
        public List<CompletedQuest2> completedQuests { get; set; }
    }

    public class CompletedQuest3
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act3
    {
        public bool completed { get; set; }
        public List<CompletedQuest3> completedQuests { get; set; }
    }

    public class CompletedQuest4
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act4
    {
        public bool completed { get; set; }
        public List<CompletedQuest4> completedQuests { get; set; }
    }

    public class Normal
    {
        public Act1 act1 { get; set; }
        public Act2 act2 { get; set; }
        public Act3 act3 { get; set; }
        public Act4 act4 { get; set; }
    }

    public class Act12
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act22
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act32
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act42
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Nightmare
    {
        public Act12 act1 { get; set; }
        public Act22 act2 { get; set; }
        public Act32 act3 { get; set; }
        public Act42 act4 { get; set; }
    }

    public class Act13
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act23
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act33
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act43
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Hell
    {
        public Act13 act1 { get; set; }
        public Act23 act2 { get; set; }
        public Act33 act3 { get; set; }
        public Act43 act4 { get; set; }
    }

    public class Act14
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act24
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act34
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act44
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Inferno
    {
        public Act14 act1 { get; set; }
        public Act24 act2 { get; set; }
        public Act34 act3 { get; set; }
        public Act44 act4 { get; set; }
    }

    public class Progression
    {
        public Normal normal { get; set; }
        public Nightmare nightmare { get; set; }
        public Hell hell { get; set; }
        public Inferno inferno { get; set; }
    }

    public class CompletedQuest5
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act15
    {
        public bool completed { get; set; }
        public List<CompletedQuest5> completedQuests { get; set; }
    }

    public class CompletedQuest6
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act25
    {
        public bool completed { get; set; }
        public List<CompletedQuest6> completedQuests { get; set; }
    }

    public class CompletedQuest7
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act35
    {
        public bool completed { get; set; }
        public List<CompletedQuest7> completedQuests { get; set; }
    }

    public class CompletedQuest8
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act45
    {
        public bool completed { get; set; }
        public List<CompletedQuest8> completedQuests { get; set; }
    }

    public class Normal2
    {
        public Act15 act1 { get; set; }
        public Act25 act2 { get; set; }
        public Act35 act3 { get; set; }
        public Act45 act4 { get; set; }
    }

    public class CompletedQuest9
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act16
    {
        public bool completed { get; set; }
        public List<CompletedQuest9> completedQuests { get; set; }
    }

    public class CompletedQuest10
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act26
    {
        public bool completed { get; set; }
        public List<CompletedQuest10> completedQuests { get; set; }
    }

    public class CompletedQuest11
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act36
    {
        public bool completed { get; set; }
        public List<CompletedQuest11> completedQuests { get; set; }
    }

    public class CompletedQuest12
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act46
    {
        public bool completed { get; set; }
        public List<CompletedQuest12> completedQuests { get; set; }
    }

    public class Nightmare2
    {
        public Act16 act1 { get; set; }
        public Act26 act2 { get; set; }
        public Act36 act3 { get; set; }
        public Act46 act4 { get; set; }
    }

    public class Act17
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class CompletedQuest13
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act27
    {
        public bool completed { get; set; }
        public List<CompletedQuest13> completedQuests { get; set; }
    }

    public class CompletedQuest14
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act37
    {
        public bool completed { get; set; }
        public List<CompletedQuest14> completedQuests { get; set; }
    }

    public class CompletedQuest15
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Act47
    {
        public bool completed { get; set; }
        public List<CompletedQuest15> completedQuests { get; set; }
    }

    public class Hell2
    {
        public Act17 act1 { get; set; }
        public Act27 act2 { get; set; }
        public Act37 act3 { get; set; }
        public Act47 act4 { get; set; }
    }

    public class Act18
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act28
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act38
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Act48
    {
        public bool completed { get; set; }
        public List<object> completedQuests { get; set; }
    }

    public class Inferno2
    {
        public Act18 act1 { get; set; }
        public Act28 act2 { get; set; }
        public Act38 act3 { get; set; }
        public Act48 act4 { get; set; }
    }

    public class HardcoreProgression
    {
        public Normal2 normal { get; set; }
        public Nightmare2 nightmare { get; set; }
        public Hell2 hell { get; set; }
        public Inferno2 inferno { get; set; }
    }

    public class ProfileJSON
    {
        public List<Hero> heroes { get; set; }
        public int lastHeroPlayed { get; set; }
        public int lastUpdated { get; set; }
        public List<Artisan> artisans { get; set; }
        public List<HardcoreArtisan> hardcoreArtisans { get; set; }
        public Kills kills { get; set; }
        public TimePlayed timePlayed { get; set; }
        public List<FallenHero> fallenHeroes { get; set; }
        public string battleTag { get; set; }
        public Progression progression { get; set; }
        public HardcoreProgression hardcoreProgression { get; set; }
    }
}