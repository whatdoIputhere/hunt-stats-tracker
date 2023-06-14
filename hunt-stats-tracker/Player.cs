class Player
{
    private string name { get; set; }
    private int bountyExtracted { get; set; }
    private int bountyPickedUp { get; set; }
    private int downedByMe { get; set; }
    private int downedByTeammate { get; set; }
    private int downedMe { get; set; }
    private int downedTeammate { get; set; }
    private bool hadWellspring { get; set; }
    private bool isPartner { get; set; }
    private bool isSoulSurvivor { get; set; }
    private int killedByMe { get; set; }
    private int killedByTeammate { get; set; }
    private int killedMe { get; set; }
    private int killedTeammate { get; set; }
    private int mmr { get; set; }
    private string profileId { get; set; }
    private bool proximityToMe { get; set; }
    private bool proximityToTeammate { get; set; }
    private bool skillBased { get; set; }
    private bool teamExtraction { get; set; }
    private string tooltipDownedByTeammate { get; set; }
    private string tooltipBountyExtracted { get; set; }
    private string tooltipBountyPickedUp { get; set; }
    private string tooltipDownedByMe { get; set; }
    private string tooltipDownedMe { get; set; }
    private string tooltipDownedTeammate { get; set; }
    private string tooltipKilledByMe { get; set; }
    private string tooltipKilledByTeammate { get; set; }
    private string tooltipKilledMe { get; set; }
    private string tooltipKilledTeammate { get; set; }

    //create player constructed with all properties
    public Player(string name, int bountyExtracted, int bountyPickedUp, int downedByMe, int downedByTeammate, int downedMe, int downedTeammate, bool hadWellspring, bool isPartner, bool isSoulSurvivor, int killedByMe, int killedByTeammate, int killedMe, int killedTeammate, int mmr, string profileId, bool proximityToMe, bool proximityToTeammate, bool skillBased, bool teamExtraction, string tooltipDownedByTeammate, string tooltipBountyExtracted, string tooltipBountyPickedUp, string tooltipDownedByMe, string tooltipDownedMe, string tooltipDownedTeammate, string tooltipKilledByMe, string tooltipKilledByTeammate, string tooltipKilledMe, string tooltipKilledTeammate)
    {
        this.name = name;
        this.bountyExtracted = bountyExtracted;
        this.bountyPickedUp = bountyPickedUp;
        this.downedByMe = downedByMe;
        this.downedByTeammate = downedByTeammate;
        this.downedMe = downedMe;
        this.downedTeammate = downedTeammate;
        this.hadWellspring = hadWellspring;
        this.isPartner = isPartner;
        this.isSoulSurvivor = isSoulSurvivor;
        this.killedByMe = killedByMe;
        this.killedByTeammate = killedByTeammate;
        this.killedMe = killedMe;
        this.killedTeammate = killedTeammate;
        this.mmr = mmr;
        this.profileId = profileId;
        this.proximityToMe = proximityToMe;
        this.proximityToTeammate = proximityToTeammate;
        this.skillBased = skillBased;
        this.teamExtraction = teamExtraction;
        this.tooltipDownedByTeammate = tooltipDownedByTeammate;
        this.tooltipBountyExtracted = tooltipBountyExtracted;
        this.tooltipBountyPickedUp = tooltipBountyPickedUp;
        this.tooltipDownedByMe = tooltipDownedByMe;
        this.tooltipDownedMe = tooltipDownedMe;
        this.tooltipDownedTeammate = tooltipDownedTeammate;
        this.tooltipKilledByMe = tooltipKilledByMe;
        this.tooltipKilledByTeammate = tooltipKilledByTeammate;
        this.tooltipKilledMe = tooltipKilledMe;
        this.tooltipKilledTeammate = tooltipKilledTeammate;
    }

    //tostring
    public override string ToString()
    {
        string output = "   PLAYER:  { \n";
        output += "     Name: " + name + "\n";
        output += "     Bounty Extracted: " + bountyExtracted + "\n";
        output += "     Bounty Picked Up: " + bountyPickedUp + "\n";
        output += "     Downed By Me: " + downedByMe + "\n";
        output += "     Downed By Teammate: " + downedByTeammate + "\n";
        output += "     Downed Me: " + downedMe + "\n";
        output += "     Downed Teammate: " + downedTeammate + "\n";
        output += "     Had Wellspring: " + hadWellspring + "\n";
        output += "     Is Partner: " + isPartner + "\n";
        output += "     Is Soul Survivor: " + isSoulSurvivor + "\n";
        output += "     Killed By Me: " + killedByMe + "\n";
        output += "     Killed By Teammate: " + killedByTeammate + "\n";
        output += "     Killed Me: " + killedMe + "\n";
        output += "     Killed Teammate: " + killedTeammate + "\n";
        output += "     MMR: " + mmr + "\n";
        output += "     Profile ID: " + profileId + "\n";
        output += "     Proximity To Me: " + proximityToMe + "\n";
        output += "     Proximity To Teammate: " + proximityToTeammate + "\n";
        output += "     Skill Based: " + skillBased + "\n";
        output += "     Team Extraction: " + teamExtraction + "\n";
        output += "     Tooltip Downed By Teammate: " + tooltipDownedByTeammate + "\n";
        output += "     Tooltip Bounty Extracted: " + tooltipBountyExtracted + "\n";
        output += "     Tooltip Bounty Picked Up: " + tooltipBountyPickedUp + "\n";
        output += "     Tooltip Downed By Me: " + tooltipDownedByMe + "\n";
        output += "     Tooltip Downed Me: " + tooltipDownedMe + "\n";
        output += "     Tooltip Downed Teammate: " + tooltipDownedTeammate + "\n";
        output += "     Tooltip Killed By Me: " + tooltipKilledByMe + "\n";
        output += "     Tooltip Killed By Teammate: " + tooltipKilledByTeammate + "\n";
        output += "     Tooltip Killed Me: " + tooltipKilledMe + "\n";
        output += "     Tooltip Killed Teammate: " + tooltipKilledTeammate + "\n";
        output += "   }";
        return output;
    }
}