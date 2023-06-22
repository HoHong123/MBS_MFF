namespace MBS.Type
{
    public enum CharacterType
    {
        Combat = 0,
        Blast,
        Speed,
        Universal,
    }

    public enum Allies
    {
        Human = 0,
        Alien,
        Creation,
        Mutant,
        Unknown,
        Spirit,
        Transcendent,
    }

    public enum Gender
    {
        None = 0,
        Male,
        Female,
    }

    public enum Side
    {
        None = 0,
        Hero,
        Villain,
    }

    public enum CrowdControl
    {
        None = 0,

        Mocking = 100,

        Charm = 111,
        Suduce,
        Paralyze,

        Stun = 222,
        MindControl,
        TimeBending,

        GuardBreak = 333,

        Panic = 555,
        Freezing,

        Bleeding = 666, // Healing debuff
        Pierce, // Remove buff
    }

    public enum DefenceStatus
    {
        None = 0,

        SuperArmor = 10,
        GuardBreakImmune,

        NoneTarget = 100,
        Invisible,

        Invincible = 111,

        Immune = 222,

        Guard = 333,

        Barrier = 444,
        Shield,
    }
}
