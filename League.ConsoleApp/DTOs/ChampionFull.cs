﻿
//namespace League.ConsoleApp.DTOs
//{

//    public class Champion
//    {
//        public string id { get; set; }
//        public string key { get; set; }
//        public string name { get; set; }
//        public string title { get; set; }
//        public Image image { get; set; }
//        public Skin[] skins { get; set; }
//        public string lore { get; set; }
//        public string blurb { get; set; }
//        public string[] allytips { get; set; }
//        public string[] enemytips { get; set; }
//        public string[] tags { get; set; }
//        public string partype { get; set; }
//        public Info info { get; set; }
//        public Stats stats { get; set; }
//        public Spell[] spells { get; set; }
//        public Passive passive { get; set; }
//        public Recommended[] recommended { get; set; }
//    }

//    public class Image
//    {
//        public string full { get; set; }
//        public string sprite { get; set; }
//        public string group { get; set; }
//    }

//    public class Info
//    {
//        public int attack { get; set; }
//        public int defense { get; set; }
//        public int magic { get; set; }
//        public int difficulty { get; set; }
//    }

//    public class Stats
//    {
//        public float hp { get; set; }
//        public int hpperlevel { get; set; }
//        public float mp { get; set; }
//        public float mpperlevel { get; set; }
//        public int movespeed { get; set; }
//        public int armor { get; set; }
//        public float armorperlevel { get; set; }
//        public float spellblock { get; set; }
//        public float spellblockperlevel { get; set; }
//        public int attackrange { get; set; }
//        public float hpregen { get; set; }
//        public float hpregenperlevel { get; set; }
//        public float mpregen { get; set; }
//        public float mpregenperlevel { get; set; }
//        public int crit { get; set; }
//        public int critperlevel { get; set; }
//        public float attackdamage { get; set; }
//        public float attackdamageperlevel { get; set; }
//        public float attackspeedperlevel { get; set; }
//        public float attackspeed { get; set; }
//    }

//    public class Passive
//    {
//        public string name { get; set; }
//        public string description { get; set; }
//        public Image1 image { get; set; }
//    }

//    public class Image1
//    {
//        public string full { get; set; }
//        public string sprite { get; set; }
//        public string group { get; set; }
//    }

//    public class Skin
//    {
//        public string id { get; set; }
//        public int num { get; set; }
//        public string name { get; set; }
//        public bool chromas { get; set; }
//    }

//    public class Spell
//    {
//        public string id { get; set; }
//        public string name { get; set; }
//        public string description { get; set; }
//        public string tooltip { get; set; }
//        public Leveltip leveltip { get; set; }
//        public int maxrank { get; set; }
//        public float[] cooldown { get; set; }
//        public string cooldownBurn { get; set; }
//        public int[] cost { get; set; }
//        public string costBurn { get; set; }
//        public Datavalues datavalues { get; set; }
//        public float[][] effect { get; set; }
//        public string[] effectBurn { get; set; }
//        public Var[] vars { get; set; }
//        public string costType { get; set; }
//        public string maxammo { get; set; }
//        public int[] range { get; set; }
//        public string rangeBurn { get; set; }
//        public Image2 image { get; set; }
//        public string resource { get; set; }
//    }

//    public class Leveltip
//    {
//        public string[] label { get; set; }
//        public string[] effect { get; set; }
//    }

//    public class Datavalues
//    {
//    }

//    public class Image2
//    {
//        public string full { get; set; }
//        public string sprite { get; set; }
//        public string group { get; set; }
//        public int x { get; set; }
//        public int y { get; set; }
//        public int w { get; set; }
//        public int h { get; set; }
//    }

//    public class Var
//    {
//        public string link { get; set; }
//        public object coeff { get; set; }
//        public string key { get; set; }
//    }

//    public class Recommended
//    {
//        public string champion { get; set; }
//        public string title { get; set; }
//        public string map { get; set; }
//        public string mode { get; set; }
//        public string type { get; set; }
//        public string customTag { get; set; }
//        public int sortrank { get; set; }
//        public bool extensionPage { get; set; }
//        public bool useObviousCheckmark { get; set; }
//        public string customPanel { get; set; }
//        public Block[] blocks { get; set; }
//        public bool priority { get; set; }
//        public string requiredPerk { get; set; }
//        public string customPanelCurrencyType { get; set; }
//        public string customPanelBuffCurrencyName { get; set; }
//        public bool extenOrnnPage { get; set; }
//    }

//    public class Block
//    {
//        public string type { get; set; }
//        public bool recMath { get; set; }
//        public bool recSteps { get; set; }
//        public int minSummonerLevel { get; set; }
//        public int maxSummonerLevel { get; set; }
//        public string showIfSummonerSpell { get; set; }
//        public string hideIfSummonerSpell { get; set; }
//        public string appendAfterSection { get; set; }
//        public string[] visibleWithAllOf { get; set; }
//        public string[] hiddenWithAnyOf { get; set; }
//        public Item[] items { get; set; }
//    }

//    public class Item
//    {
//        public string id { get; set; }
//        public int count { get; set; }
//        public bool hideCount { get; set; }
//    }

//}
