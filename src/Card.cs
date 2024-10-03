public class Card
{
    public string Suit  { get; private set; }
    public string Rank  { get; private set; }
    public double Value { get; private set; }
    public static readonly Dictionary<string, string> SuitUnicode = new Dictionary<string, string>
        {
            { "Spades", "\u2660" },
            { "Diamonds", "\u2666" },
            { "Hearts", "\u2665" },
            { "Clubs", "\u2663" }
        };

    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
        
        if (Rank == "Jack" || Rank == "Queen" || Rank == "King") // Set Royalty cards as 10 
        { Value = 10.0; }
        else if (Rank == "Ace") // Set Aces as 1 for now, flex will be built-in later
        {  Value = 1.0; }
        else // If it is a numerical value card
        {  Value = double.Parse(Rank); }

    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }

}