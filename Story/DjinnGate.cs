//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
using RBot;

public class DjinnGateStory
{
    public ScriptInterface Bot => ScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new CoreStory();

    private string[] drops =
    {
     "Armor of Zular", "Djinn's Essence", "Unseen Essence", "Fangs of the Lion", "Claws of the Daeva", "Light of the Serpent", "Pike of the Shimmering Sands", "Reavers of the Gilded Sun"
    };

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        DjinnGate();

        Core.SetOptions(false);
    }

    public void DjinnGate()
    {
        if (Core.isCompletedBefore(6161))
            return;

        Story.PreLoad();

        Core.AddDrop(drops);

        if (!Story.QuestProgression(6153))
        {
            Core.EnsureAccept(6153);
            Core.KillMonster("mobius", "Slugfit", "Left", "Slugfit", "Fragment 1");
            Core.KillMonster("faerie", "TopRock", "Left", "*", "Fragment 2");
            Core.KillMonster("faerie", "Side4", "Right", "*", "Fragment 3");
            Core.KillMonster("faerie", "End", "Center", "Cyclops Warlord", "Fragment 4");
            Core.KillMonster("cornelis", "Side1", "Left", "*", "Fragment 5");
            Core.EnsureComplete(6153);
        }

        if (!Story.QuestProgression(6154))
        {
            Core.EnsureAccept(6154);
            Core.KillMonster("arcangrove", "Left", "Left", "*", "Fragment 6");
            Core.KillMonster("cloister", "r8", "Left", "*", "Fragment 7");
            Core.KillMonster("gilead", "r5", "Right", "Bubblin", "Fragment 8");
            Core.KillMonster("natatorium", "r2", "Left", "Merdraconian", "Fragment 9");
            Core.KillMonster("mafic", "r6", "Left", "*", "Fragment 10");
            Core.EnsureComplete(6154);
        }

        if (!Story.QuestProgression(6155))
        {
            Core.EnsureAccept(6155);
            Core.KillMonster("mythsong", "Hill", "Right", "*", "Fragment 11");
            Core.HuntMonster("palooza", "Rock Lobster", "Fragment 12");
            Core.HuntMonster("palooza", "Stinger", "Fragment 13");
            Core.HuntMonster("beehive", "Killer Queen Bee", "Fragment 14");
            Core.HuntMonster("palooza", "Mozard", "Fragment 15");
            Core.EnsureComplete(6155);
        }

        if (!Story.QuestProgression(6156))
        {
            Core.EnsureAccept(6156);
            Core.KillMonster("forestchaos", "Boss", "Left", "*", "Fragment 16");
            Core.KillMonster("guru", "Field2", "Left", "*", "Fragment 17");
            Core.KillMonster("marsh", "Forest3", "Left", "Dark Witch", "Fragment 18");
            Core.KillMonster("marsh", "Forest3", "Left", "Spider", "Fragment 19");
            Core.KillMonster("marsh2", "End", "Left", "Soulseeker", "Fragment 20");
            Core.EnsureComplete(6156);
        }

        if (!Story.QuestProgression(6157))
        {
            Core.EnsureAccept(6157);
            Core.KillMonster("pirates", "End", "Left", "Shark Bait", "Fragment 21");
            Core.KillMonster("pirates", "End", "Left", "Fishwing", "Fragment 25");
            Core.KillMonster("yokairiver", "r2", "Left", "Kappa Ninja", "Fragment 22");
            Core.KillMonster("bamboo", "Enter", "Spawn", "*", "Fragment 23");
            Core.KillMonster("yokaiwar", "War2", "Left", "Samurai Nopperabo", "Fragment 24");
            Core.EnsureComplete(6157);
        }

        if (!Story.QuestProgression(6158))
        {
            Core.EnsureAccept(6158);
            Core.EquipClass(ClassType.Solo);
            Core.KillMonster("doomkitten", "Enter", "Spawn", "*", "Potent DoomKitten Mana", publicRoom: true);
            Core.KillMonster("bloodtitan", "Ultra", "Left", "*", "Potent Blood Titan Mana");
            Core.HuntMonster("trigoras", "Trigoras", "Potent Trigoras Mana");
            Core.KillMonster("phoenixrise", "r8", "Left", "*", "Potent CinderClaw Mana");
            Core.KillMonster("thevoid", "r16", "Left", "*", "Potent Reaper Mana", publicRoom: true);
            Core.EnsureComplete(6158);
        }

        Story.MapItemQuest(6159, "djinngate", 5571, 5, false);

        if (!Story.QuestProgression(6160))
        {
            Core.EquipClass(ClassType.Farm);
            Core.EnsureAccept(6160);
            Core.HuntMonster("djinngate", "Harpy", "Djinn's Essence", 100, isTemp: false);
            Core.EnsureComplete(6160);
        }

        if (!Story.QuestProgression(6160))
        {
            Core.EquipClass(ClassType.Solo);
            Core.EnsureAccept(6161);
            Core.HuntMonster("djinngate", "Gedoz", "Gedoz the Malignant Defeated");
            Core.EnsureComplete(6161);
        }

        Core.ToBank(drops);
    }
}