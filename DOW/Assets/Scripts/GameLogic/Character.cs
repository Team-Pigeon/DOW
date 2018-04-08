using System.Collections.Generic;

class Character
{
    private readonly string name;
    //public string Name { get { return Name; } private set { } }
    //public string Name { get; private set; }

    //private int charismValue;
    //private int attackValue;
    //private int searchValue;
    public int CharismValue { get; set; }
    public int AttackValue { get; set; }
    public int SearchValue { get; set; }

    private List<Wound> wounds;

    public Character(string name, int charismValue, int attackValue, int searchValue)
    {
        this.name = name;
        //this.charismValue = charismValue;
        //this.attackValue = attackValue;
        //this.searchValue = searchValue;
        CharismValue = charismValue;
        AttackValue = attackValue;
        SearchValue = searchValue;

        wounds = new List<Wound>();
    }

    public string getName()
    {
        return name;
    }

    public IList<Wound> getWounds()
    {
        return wounds.AsReadOnly();
    }

    public int getWoundsNumber()
    {
        return wounds.Count;
    }

    public void addWound(Wound wound)
    {
        wounds.Add(wound);

        // FIXME : Add code to deal with 3 wounds (lethal situation) ?
    }

    public void removeWound(Wound wound)
    {
        bool result = wounds.Remove(wound);

        if (!result)
        {
            throw new System.InvalidOperationException("Failed to remove wound [" + wound + "] from character [" + this + "].");
        }
    }
}
