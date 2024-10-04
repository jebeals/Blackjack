using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

public abstract class CardGame
{
    public string? Name {get; set;}
    public virtual Deck Deck {get; set;}
    public virtual List<Player> Players {get; set;}
    // public virtual Player player {get; set; }
    public int numPlayers {get; set; }
    public int numDecks { get; set; }
    
    protected List<Hand>? History {get; set;}
    
    public CardGame()
    {
        Deck = new Deck();
        Deck.Shuffle();
        Players = new List<Player>();

    }
    public CardGame(int numPlayers, int numDecks)
    {
        // Set obvious attributes
        this.numPlayers = numPlayers;
        this.numDecks = numDecks; 

        // Create the deck
        Deck = new Deck(numDecks);
        Deck.Shuffle(); // Shuffle the deck
        Players = new List<Player>(); // New list of players creation
        for (int i = 0; i <numPlayers; i++) 
            { Players.Add(new Player()); }
    }
}