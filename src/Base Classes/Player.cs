public class Player 
{
    // name
    public string Name {get; set; }

    // hand
    public virtual Hand? Hand {get; set; }

    // role
    public string? Role {get; set; }

    // bank
    public virtual double Bank {get; set; }

    // constructor
    public Player()
    {
        // Nothing here
        Name = ""; 
    }
    public Player(string name, Hand hand, string role, double bank) {
        this.Name = name;
        this.Hand = hand;
        this.Role = role;
        this.Bank = bank;
    }

    public Player(int playerNumber, Hand hand, string role, double bank) {
        this.Name = $"Player {playerNumber}";
        this.Hand = hand;
        this.Role = role;
        this.Bank = bank;
    }

    public Player(string name, string role, double bank) {
        this.Name = name;
        this.Role = role;
        this.Bank = bank;
    }

    public Player(string name, Hand hand, double bank) {
        this.Name = name;
        this.Hand = hand;
        this.Bank = bank;
    }

    public Player(string name, double bank) {
        this.Name = name;
        this.Bank = bank;
    }

    private string GetAction() {
        return "";
    }
}