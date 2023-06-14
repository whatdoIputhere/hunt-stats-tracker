class Team
{
    private int mmr;
    private bool isInvite;
    private bool ownTeam;
    private int handicap;
    private int numberOfPlayers;
    private List<Player> players;

    public Team(int mmr, bool isInvite, bool ownTeam, int handicap, int numberOfPlayers)
    {
        this.mmr = mmr;
        this.isInvite = isInvite;
        this.ownTeam = ownTeam;
        this.handicap = handicap;
        this.numberOfPlayers = numberOfPlayers;
        this.players = new List<Player>();
    }
    //getters and setters
    public int MMR { get => mmr; set => mmr = value; }
    public bool IsInvite { get => isInvite; set => isInvite = value; }
    public bool OwnTeam { get => ownTeam; set => ownTeam = value; }
    public int Handicap { get => handicap; set => handicap = value; }
    public int NumberOfPlayers { get => numberOfPlayers; set => numberOfPlayers = value; }
    public List<Player> Players { get => players; set => players = value; }


    //tostring method with all properties and labels including players
    public override string ToString()
    {
        string output = "TEAM: {\n";
        output += " MMR: " + mmr + "\n";
        output += " Is Invite: " + isInvite + "\n";
        output += " Own Team: " + ownTeam + "\n";
        output += " Handicap: " + handicap + "\n";
        output += " Number of Players: " + numberOfPlayers + "\n";
        output += " Players: { \n";
        foreach (Player player in players)
        {
            output += player.ToString() + "\n";
        }
        output += "} \n";
        return output;
    }


}