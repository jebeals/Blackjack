public class Player {
    // name
    public string Name {get; set; }

    // hand
    public Hand? Hand {get; set; }

    // role
    public string? Role {get; set; }

    // bank
    public int Bank {get; set; }

    // constructor
    public Player(string name, Hand hand, string role, int bank) {
        this.Name = name;
        this.Hand = hand;
        this.Role = role;
        this.Bank = bank;
    }

    public Player(int playerNumber, Hand hand, string role, int bank) {
        this.Name = $"Player {playerNumber}";
        this.Hand = hand;
        this.Role = role;
        this.Bank = bank;
    }

    public Player(string name, string role, int bank) {
        this.Name = name;
        this.Role = role;
        this.Bank = bank;
    }

    public Player(string name, Hand hand, int bank) {
        this.Name = name;
        this.Hand = hand;
        this.Bank = bank;
    }

    public Player(string name, int bank) {
        this.Name = name;
        this.Bank = bank;
    }

    private string GetAction() {
        return "";
    }
}