namespace DoorGenerator
{
   enum Oppenness
    {
        OPEN,
        CLOSE,
        LEANED
    }
    enum Material
    {
        WOOD,
        STONE,
        METAL,
        GLASS,
        FABRIC
    };

    enum Construction
    {
        SOLID,
        DECREPID,
        BARS,
        WINDOWED
    };

    enum Locked
    {
        LOCKED,
        MULTIPLE,
        UNLOCKED,
        BARRED,
    };

    enum Locktype
    {
        INTEGRATED,
        PADLOCK,
        BAR,
        CHAIN,
        CLUTTER
    };
}
