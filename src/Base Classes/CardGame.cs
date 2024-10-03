using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

public abstract class CardGame
{
    
    public string? Name {get; set;}
    public Deck Deck {get; set;}
    public List<Hand> Players {get; set;}
    
    protected List<Hand>? History {get; set;}
    
    public CardGame()
    {
        Deck = new Deck();
        Deck.Shuffle();
        Players = new List<Hand>();

    }
    public CardGame(int numPlayers, int numDecks)
    {
        Deck = new Deck(numDecks);
        Deck.Shuffle();
        Players = new List<Hand>();
        for (int i = 0; i <numPlayers; i++)
        {
            Players.Add(new Hand());
        }
    }
}