using System.Xml;
string filepath = @"C:\Program Files (x86)\Steam\steamapps\common\Hunt Showdown\user\profiles\default\attributes.xml";

void main()
{
    List<XmlNode> missionBagTeam = new List<XmlNode>();
    List<XmlNode> missionBagPlayer = new List<XmlNode>();
    List<XmlNode> missionBag = new List<XmlNode>();

    List<Team> teams = new List<Team>();

    populateMissionBagLists(missionBagTeam, missionBagPlayer, missionBag);

    int numberOfTeams = getNumberOfTeams(missionBag);
    if (numberOfTeams == -1)
    {
        System.Console.WriteLine("Error getting number of teams");
        return;
    }

    populateTeams(missionBagTeam, missionBagPlayer, teams, numberOfTeams);

    writeToFile(teams);

}

void writeToFile(List<Team> teams)
{
    string teamsStr = "";
    foreach (Team team in teams)
    {
        teamsStr += team.ToString() + "------------------------------------\n";
    }

    using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\teams.txt", false))
    {
        writer.Write(teamsStr);
    }
}

void populateTeams(List<XmlNode> missionBagTeam, List<XmlNode> missionBagPlayer, List<Team> teams, int numberOfTeams)
{
    int[] numberOfPlayersPerTeam = new int[numberOfTeams];
    for (int i = 0; i < numberOfTeams; i++)
    {
        List<XmlNode> teamNodes = missionBagTeam.FindAll(x => x.Attributes!["name"]!.Value.Contains($"MissionBagTeam_{i}_"));
        int handicap = 0;
        int mmr = 0;
        bool isInvite = false;
        bool ownTeam = false;
        int numberOfPlayers = 0;
        bool valid = true;
        foreach (XmlNode node in teamNodes)
        {
            if (node.OuterXml.Contains("handicap"))
                handicap = Int32.Parse(node.Attributes!["value"]!.Value);
            else if (node.OuterXml.Contains("mmr"))
                mmr = Int32.Parse(node.Attributes!["value"]!.Value);
            else if (node.OuterXml.Contains("isinvite"))
                isInvite = Boolean.Parse(node.Attributes!["value"]!.Value);
            else if (node.OuterXml.Contains("ownteam"))
                ownTeam = Boolean.Parse(node.Attributes!["value"]!.Value);
            else if (node.OuterXml.Contains("numplayers"))
                numberOfPlayers = Int32.Parse(node.Attributes!["value"]!.Value);
            else
                valid = false;
        }

        if (valid)
            teams.Add(new Team(mmr, isInvite, ownTeam, handicap, numberOfPlayers));
    }
    for (int i = 0; i < numberOfTeams; i++)
    {
        List<Player> players = new List<Player>();
        for (int j = 0; j < teams[i].NumberOfPlayers; j++)
        {
            List<XmlNode> playerNodes = missionBagPlayer.FindAll(x => x.Attributes!["name"]!.Value.Contains($"MissionBagPlayer_{i}_{j}_"));
            string name = "";
            int bountyExtracted = 0;
            int bountyPickedUp = 0;
            int downedByMe = 0;
            int downedByTeammate = 0;
            int downedMe = 0;
            int downedTeammate = 0;
            bool hadWellspring = false;
            bool isPartner = false;
            bool isSoulSurvivor = false;
            int killedByMe = 0;
            int killedByTeammate = 0;
            int killedMe = 0;
            int killedTeammate = 0;
            int mmr = 0;
            string profileId = "";
            bool proximityToMe = false;
            bool proximityToTeammate = false;
            bool skillBased = false;
            bool teamExtraction = false;
            string tooltipDownedByTeammate = "";
            string tooltipBountyExtracted = "";
            string tooltipBountyPickedUp = "";
            string tooltipDownedByMe = "";
            string tooltipDownedMe = "";
            string tooltipDownedTeammate = "";
            string tooltipKilledByMe = "";
            string tooltipKilledByTeammate = "";
            string tooltipKilledMe = "";
            string tooltipKilledTeammate = "";
            bool valid = true;

            foreach (XmlNode node in playerNodes)
            {
                if (node.OuterXml.Contains("_line_name"))
                    name = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_bountyextracted"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out bountyExtracted);
                else if (node.OuterXml.Contains("_bountypickedup"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out bountyPickedUp);
                else if (node.OuterXml.Contains("_downedbyme"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out downedByMe);
                else if (node.OuterXml.Contains("_downedbyteammate"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out downedByTeammate);
                else if (node.OuterXml.Contains("_downedme"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out downedMe);
                else if (node.OuterXml.Contains("_downedteammate"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out downedTeammate);
                else if (node.OuterXml.Contains("_hadWellspring"))
                    hadWellspring = Boolean.Parse(node.Attributes!["value"]!.Value);
                else if (node.OuterXml.Contains("_ispartner"))
                    isPartner = Boolean.Parse(node.Attributes!["value"]!.Value);
                else if (node.OuterXml.Contains("_issoulsurvivor"))
                    isSoulSurvivor = Boolean.Parse(node.Attributes!["value"]!.Value);
                else if (node.OuterXml.Contains("_killedbyme"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out killedByMe);
                else if (node.OuterXml.Contains("_killedbyteammate"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out killedByTeammate);
                else if (node.OuterXml.Contains("_killedme"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out killedMe);
                else if (node.OuterXml.Contains("_killedteammate"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out killedTeammate);
                else if (node.OuterXml.Contains("_mmr"))
                    Int32.TryParse(node.Attributes!["value"]!.Value, out mmr);
                else if (node.OuterXml.Contains("_profileid"))
                    profileId = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_proximitytome"))
                    proximityToMe = Boolean.Parse(node.Attributes!["value"]!.Value);
                else if (node.OuterXml.Contains("_proximitytoteammate"))
                    proximityToTeammate = Boolean.Parse(node.Attributes!["value"]!.Value);
                else if (node.OuterXml.Contains("_skillbased"))
                    skillBased = Boolean.Parse(node.Attributes!["value"]!.Value);
                else if (node.OuterXml.Contains("_teamextraction"))
                    teamExtraction = Boolean.Parse(node.Attributes!["value"]!.Value);
                else if (node.OuterXml.Contains("_tooltip_downedbyteammate"))
                    tooltipDownedByTeammate = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_tooltipbountyextracted"))
                    tooltipBountyExtracted = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_tooltipbountypickedup"))
                    tooltipBountyPickedUp = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_tooltipdownedbyme"))
                    tooltipDownedByMe = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_tooltipdownedme"))
                    tooltipDownedMe = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_tooltipdownedteammate"))
                    tooltipDownedTeammate = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_tooltipkilledbyme"))
                    tooltipKilledByMe = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_tooltipkilledbyteammate"))
                    tooltipKilledByTeammate = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_tooltipkilledme"))
                    tooltipKilledMe = node.Attributes!["value"]!.Value;
                else if (node.OuterXml.Contains("_tooltipkilledteammate"))
                    tooltipKilledTeammate = node.Attributes!["value"]!.Value;
                else
                    valid = false;
            }
            if (valid)
                players.Add(new Player(name, bountyExtracted, bountyPickedUp, downedByMe, downedByTeammate, downedMe, downedTeammate, hadWellspring, isPartner, isSoulSurvivor, killedByMe, killedByTeammate, killedMe, killedTeammate, mmr, profileId, proximityToMe, proximityToTeammate, skillBased, teamExtraction, tooltipDownedByTeammate, tooltipBountyExtracted, tooltipBountyPickedUp, tooltipDownedByMe, tooltipDownedMe, tooltipDownedTeammate, tooltipKilledByMe, tooltipKilledByTeammate, tooltipKilledMe, tooltipKilledTeammate));
        }
        teams[i].Players = players;
    }

}

int getNumberOfTeams(List<XmlNode> missionBag)
{
    XmlNode? numberOfTeamsNode = missionBag!.Find(x => x.Attributes!["name"]!.Value == "MissionBagNumTeams");
    if (numberOfTeamsNode != null)
        return Int32.Parse(numberOfTeamsNode.Attributes!["value"]!.Value);
    return -1;
}


void populateMissionBagLists(List<XmlNode> teamInfo, List<XmlNode> playerInfo, List<XmlNode> missionBag)
{
    XmlDocument doc = new XmlDocument();
    try
    {
        string text = File.ReadAllText(filepath);
        doc.LoadXml(text);
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("Error reading file");
        throw;
    }

    try
    {
        foreach (XmlNode node in doc.SelectNodes("//Attr")!)
        {
            string attributeName = node.Attributes!["name"]!.Value;
            string attributeValue = node.Attributes["value"]!.Value;

            if (attributeName.Contains("MissionBagPlayer"))
            {
                playerInfo.Add(node);
            }
            else if (attributeName.Contains("MissionBagTeam"))
            {
                teamInfo.Add(node);
            }
            else if (attributeName.Contains("MissionBag"))
            {
                missionBag.Add(node);
            }
        }
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("Error parsing file");
        throw;
    }
}

main();