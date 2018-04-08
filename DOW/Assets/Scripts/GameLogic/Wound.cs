class Wound
{
    public enum WoundType
    {
        SIMPLE_WOUND,
        FROST
        //DEPRESSION // Only used in The Long Night
    }

    private readonly WoundType type;

    public Wound(WoundType type)
    {
        this.type = type;
    }

    public WoundType getType()
    {
        return type;
    }
}
