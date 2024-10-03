public class BlackjackHand : Hand
{
    public bool isSoftHand { get; set;}
    public int Value { get; set; }

    public BlackjackHand() : base ()
    {
        // Cards already instantiated in class attributes
    }
    public BlackjackHand(string Name) : base(Name)
    { 
        // this.Name = Name; 
    }
    public BlackjackHand(int numCards, Deck deck) : base (numCards, deck)
    {
        //Cards = deck.Deal(numCards);
    }
    public BlackjackHand(string Name, int numCards, Deck deck) : base (Name, numCards, deck)
    {
        // this.Name = Name;
        // Cards = deck.Deal(numCards);
    }



}