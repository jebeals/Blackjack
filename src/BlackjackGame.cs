using System.Security;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

public class BlackjackGame : CardGame
{
    // public string Name {get; }
    public Player Dealer {get; set; }

    # region Inherited Field Reference
    // public Deck? Deck {get; set; } //INHERITED
    // public List<Player>? Players {get; set;} //INHERITED
    #endregion

    public BlackjackGame()
    {
        Name = "Blackjack";
        Deck = new Deck();
        Dealer = new Player();

    }
    public BlackjackGame(int numPlayers, int numDecks) //: CardGame(int numPlayers, int numDecks)
    {

        Name = $"{numDecks} Deck Blackjack";
        Deck = new Deck(numDecks);
        Deck.Shuffle();

        //public BlackjackPlayer(string name, BlackjackHand hand, string role, double bank) : base(name, hand, role, bank)
        BlackjackHand dealerHand = new BlackjackHand("Dealer"); 
        Dealer = new BlackjackPlayer("Dealer","Dealer",0.0,new BlackjackHand("Dealer")); // Set up the Dealer's Hand
        for (int i = 0; i < numPlayers; i++) // Set up the Players Hands
        {
            Players.Add(new BlackjackPlayer($"P{i+1}","Player",0.0,new BlackjackHand($"P{i+1}"))); // Add in new player hands and call them P1, P2, etc.
        }

    }
    public static void DealBlackjackHand(Deck deck, Player dealer, List<Player> players)
    {
        // Method to Deal out the intial BlackJack hand

        for (int i = 0; i < 2; i++) // Deal two cards to each player (and the dealer)
        {
            foreach (var player in players) //foreach player
            {
                player.Hand.Add(deck.Deal(1)); // Deal one card to player
            }
            dealer.Hand.Add(deck.Deal(1));   // Deal one card to dealer 
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
            Console.Write($"P{k}: ");
            player.Hand.Show(); // Players[k-1].Hand.Show();
            k++;
        }
        Console.Write("\n");
        Console.Write("Dealer: "); Dealer.Hand.ShowTop();

        Console.Write("\nWould you like to play this Blackjack game? (Y/N): ");
        string input = Console.ReadLine(); 

        if (string.Equals(input.ToLower(),"y"))
        {
            // Start the BlackJack Game
            PlayBlackJack();
        }

        return;

    }



    
    // 
    public void PlayBlackJack(string ChosenPlayer = "P1")
    {

        Console.WriteLine($"Starting an interactive game of BlackJack as {ChosenPlayer}...");
        
        // Ensure that the BlackJack game has indeed been initiated...
        
        
        //

        int k = 1; 
        foreach (var player in Players)
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

    // public static int BasicStrategy(Hand Player, Hand Dealer)
    // {


    // }
    // public static int BasicStrategy(Hand playerHand, int dealerUpCard)
    // {
        
    //     double playerTotal = playerHand.GetValue(); 
    //     bool isSoftHand = playerHand.Contains(11); // Check if player has an Ace counted as 11
        
    //     // Check for surrender option (based on common surrender rules)
    //     if (playerTotal == 16 && (dealerUpCard == 9 || dealerUpCard == 10 || dealerUpCard == 11)) 
    //         return 2; // Surrender on 16 vs. 9, 10, or Ace
    //     if (playerTotal == 15 && dealerUpCard == 10) 
    //         return 2; // Surrender on 15 vs. 10

    //     // Check for pairs (splitting rules not included in the basic strategy)
    //     if (playerHand.Count == 2 && playerHand[0] == playerHand[1])
    //     {
    //         int pairValue = playerHand[0];
    //         if (pairValue == 8 || pairValue == 11) 
    //             return 0; // Always stand with a pair of 8's or Aces
    //     }

    //     // Basic strategy based on player's hand and dealer's upcard
    //     if (isSoftHand)
    //     {
    //         // Soft hand strategy (player has an Ace)
    //         if (playerTotal <= 17)
    //             return 1; // Hit if soft total <= 17
    //         else if (playerTotal == 18)
    //         {
    //             if (dealerUpCard >= 9) return 1; // Hit if soft 18 and dealer 9 or higher
    //             else return 0; // Stand if soft 18 and dealer 8 or lower
    //         }
    //         else
    //             return 0; // Stand if soft total >= 19
    //     }
    //     else
    //     {
    //         // Hard hand strategy
    //         if (playerTotal <= 8)
    //             return 1; // Always hit on hard totals <= 8
    //         else if (playerTotal == 9)
    //         {
    //             if (dealerUpCard >= 3 && dealerUpCard <= 6) return 0; // Stand if dealer shows 3-6
    //             else return 1; // Hit otherwise
    //         }
    //         else if (playerTotal == 10)
    //         {
    //             if (dealerUpCard <= 9) return 0; // Stand if dealer shows 9 or less
    //             else return 1; // Hit otherwise
    //         }
    //         else if (playerTotal == 11)
    //             return 0; // Always stand on hard 11
    //         else if (playerTotal >= 12 && playerTotal <= 16)
    //         {
    //             if (dealerUpCard >= 7) return 1; // Hit if dealer shows 7 or higher
    //             else return 0; // Stand if dealer shows 6 or less
    //         }
    //         else
    //             return 0; // Always stand on 17 or higher
    //     }
    // }

    # region Override Methods

    // What is this used for? -JB 10/03/24
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
            
    // What is this used for? -JB 10/03/24
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        throw new System.NotImplementedException();
        return base.GetHashCode();
    }
    # endregion 

} // End BlackjackGame class



