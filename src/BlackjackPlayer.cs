public class BlackjackPlayer : Player
{
    private BlackjackHand? _blackjackHand;

    public BlackjackPlayer()
    {
        Hand = new BlackjackHand(); 
    }
    public BlackjackPlayer(string Name)
    {
        this.Name = Name;
        Hand = new BlackjackHand(); 
    }
    public BlackjackPlayer(string name, Hand hand, string role, double bank) : base(name, hand, role, bank)
    {
            // Everything kept the same; just redirect the Hand variable's {get; set; }
            _blackjackHand = new BlackjackHand(); 
    }
    public BlackjackPlayer(string name, string role, double bank, BlackjackHand hand) : base(name, role, bank)
    {
            // Everything kept the same; just redirect the Hand variable's {get; set; }
            _blackjackHand = hand; 
    }

    public override Hand? Hand 
    {
        get { return _blackjackHand; } // Return BlackjackHand _blackjackHand instead of Hand Hand :D 
        set { // Ensure the the tye is a BlackjackHand for error prefvention in further usage
            if (value is BlackjackHand blackjackHand) { _blackjackHand = blackjackHand; }
            else { throw new InvalidOperationException("Hand must be of type 'BlackjackHand'"); }
        }
    }
}