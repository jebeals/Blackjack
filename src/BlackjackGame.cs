using System.Security;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

public class BlackjackGame : CardGame
{
    // public string Name {get; }
    public Hand Dealer {get; set; }
    // public Deck Deck {get; set; }
    // public List<Hand>? Players {get; set;}

    public BlackjackGame()
    {
        Name = "Blackjack";
        Deck = new Deck();
        Dealer = new Hand();

    }
    public BlackjackGame(int numPlayers, int numDecks) //: CardGame(int numPlayers, int numDecks)
    {
        
        Name = $"{numDecks} Deck Blackjack";
        Deck = new Deck(numDecks);
        Deck.Shuffle();

        // Set up the Players Hands
        Dealer = new Hand("Dealer");
        for (int i = 0; i < numPlayers; i++)
        {
            Players.Add(new Hand($"P{i}"));
        }

    }

    public void StartBlackjackGame(int numPlayers, int numDecks)
    {
        // First thing is first, create the decks
        Deck.Shuffle();

        // Now deal out to the players and the dealer
        DealBlackjackHand(Deck,Dealer,Players);

        // Show the Board:
        Console.WriteLine($"A Game of blackjack  with {numPlayers} players and {numDecks} deck(s)! ... \n");
        int k = 1;
        foreach (var player in Players)
        {
            Console.Write($"P{k}: "); Players[k-1].Show();
            k++;
        }
        Console.Write("\n");
        Console.Write("Dealer: "); Dealer.ShowTop();

        Console.Write("\nWould you like to play this Blackjack game? (Y/N): ");
        string input = Console.ReadLine(); 

        if (string.Equals(input.ToLower(),"y"))
        {
            // Start the BlackJack Game
            PlayBlackJack();
        }

        return;

    }

    public static void DealBlackjackHand(Deck deck, Hand dealer, List<Hand> players)
    {
        for (int i = 0; i < 2; i++)
        {
            foreach (var hand in players)
            {
                hand.Add(deck.Deal(1));
            }
            dealer.Add(deck.Deal(1));
        }

    }

    

    public void PlayBlackJack(string ChosenPlayer = "P1")
    {

        Console.WriteLine($"Starting an interactive game of BlackJack as {ChosenPlayer}...");
        
        // Ensure that the BlackJack game has indeed been initiated...
        
        
        //

        int k = 1; 
        foreach (Hand player in Players)
        {
            if (player.Name != null && string.Equals(player.Name.ToLower(),ChosenPlayer.ToLower()))
            {
                //Console.WriteLi
            }
            else if (string.Equals(ChosenPlayer.ToLower(),$"P{k}".ToLower()))
            {

            }

                    

        }
    }
    public override bool Equals(object obj)
    {
        //
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //
        
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        // TODO: write your implementation of Equals() here
        throw new System.NotImplementedException();
        return base.Equals (obj);
    }
            
    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        throw new System.NotImplementedException();
        return base.GetHashCode();
    }

} // End BlackjackGame class

