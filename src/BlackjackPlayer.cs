public class BlackjackPlayer : Player
{
    private BlackjackHand? _blackjackHand;

    public BlackjackPlayer()
    {
        // No new constructors to add. Already present in Player.cs
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