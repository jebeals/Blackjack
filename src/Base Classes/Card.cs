using System.Net.Http.Headers;

public class Card
{
    public string Suit  { get; private set; }
    public string Rank  { get; private set; }
    public int Value { get; set; }
    public static readonly Dictionary<string, string> SuitUnicode = new Dictionary<string, string>
        {
            { "Spades", "\u2660" },
            { "Diamonds", "\u2666" },
            { "Hearts", "\u2665" },
            { "Clubs", "\u2663" }
        };

    public Card(string suit, string rank)
    {
        this.Suit = suit;
        this.Rank = rank;
        
        GetValue(suit,rank); // dont need to capture the output

    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }

    public virtual int GetValue(string suit, string rank)
    {
        // Method to assign numerical values to cards
        if (Rank == "Jack" || Rank == "Queen" || Rank == "King") // Set Royalty cards as 10 
        { this.Value = 10; }
        else if (Rank == "Ace") // Set Aces as 1 for now, flex will be built-in later
        {  this.Value = 1; }
        else // If it is a numerical value card
        {  this.Value = int.Parse(Rank); }

        return this.Value; 

    }


}