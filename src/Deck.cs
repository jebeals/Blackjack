public class Deck
{
    private static readonly string[] Suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
    private static readonly string[] Ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
    public List<Card>? AvailCards; 

    public Stack<Card>? CardStack;
    public List<Card> CardList; 
    public int idxCard = 0; 
    
    

    public Deck()
    {
        // Create the Deck (as a List of all cards)
        AvailCards = new List<Card>();
        foreach (var suit in Suits)
        {
            foreach (var rank in Ranks)
            {
                AvailCards.Add(new Card(suit, rank));
            }
        }

        // Create the CardStack before exiting the constructor
        CardStack = new Stack<Card>(AvailCards);
        CardList  = new List<Card>(AvailCards); 

        // Now shuffle the cards in the stack 
        // Shuffle();
    }
    public Deck(int numDecks = 1)
    {
        // Create the Deck (as a List of all cards)
        AvailCards = new List<Card>();
        int n = 0;
        while (n < numDecks)
        {
            foreach (var suit in Suits)
            {
                foreach (var rank in Ranks)
                {
                    AvailCards.Add(new Card(suit, rank));
                }
            }
            n++; 
        }

        // Create the CardStack before exiting the constructor
        CardStack = new Stack<Card>(AvailCards);
        CardList  = new List<Card>(AvailCards); 

        // Now shuffle the cards in the stack 
    }

    public void Shuffle()
    {
        // Shuffle cards from CardList into a CardStack
        List<Card> tempList = new List<Card>(AvailCards); // Create a temporary list of the list of cards that we can manipulate
        CardStack = new Stack<Card>();
        Random rng = new Random();
        int n = tempList.Count;
        while (n > 0)
        {
            int k = rng.Next(n); //Random index within the range of tempList (n)
            Card card = tempList[k]; // Pull card from that index
            CardStack.Push(card); // Push card onto CardStack (the Deck)
            tempList.RemoveAt(k); // Remove card from tempList
            n--; // iterate down one nax and repeat until exhausted
        }
        CardList = new List<Card>(CardStack); 

    }

    public void Show()
    {
        Console.WriteLine("Showing CardStack: ");
        int n = 0;
        foreach (var card in CardStack)
        {
            if (n == CardStack.Count()-1) { Console.WriteLine(card.Rank[0] + Card.SuitUnicode[card.Suit]); break; }
            Console.Write(card.Rank[0] + Card.SuitUnicode[card.Suit] + ", ");
            n++; 
            //Console.WriteLine(card.Rank[0] + SuitUnicode[card.Suit]); 
        }
    }

    public List<Card> Deal(int num = 1)
    {
        List<Card> dealtCards = new List<Card>();

        int k = 0;
        while (k < num)
        {
            if (idxCard >= CardList.Count()) 
            { return dealtCards; }

            // Otherwise Deal the cards by adding the list of dealt cards:
            dealtCards.Add(CardStack.Pop());
            idxCard++; 
            k++;
        }

        // Return dealt cards 
        return dealtCards;

    }

}
