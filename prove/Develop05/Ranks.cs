using System;

class Rank
{
    public string Name { get; }
    public int PointsRequired { get; }
    public Rank(string name, int pointsRequired)
    {
        Name = name;
        PointsRequired = pointsRequired;
    }

    private static readonly Rank[] Ranks = new Rank[]
    {
        new Rank("Beginner", 0),
        new Rank("Rookie", 5000),
        new Rank("Amateur", 10000),
        new Rank("Novice", 20000),
        new Rank("Enthusiast", 30000),
        new Rank("Skillful", 40000),
        new Rank("Intermediate", 50000),
        new Rank("Experienced", 60000),
        new Rank("Advanced", 70000),
        new Rank("Expert", 80000),
        new Rank("Pro", 90000),
        new Rank("Master", 100000),
        new Rank("Grandmaster", 150000),
        new Rank("Champion", 200000),
        new Rank("Legend", 250000),
        new Rank("Hero", 300000),
        new Rank("Superhero", 350000),
        new Rank("Elite", 400000),
        new Rank("Supreme", 450000),
        new Rank("Godlike", 500000),
        new Rank("Immortal", 550000),
        new Rank("Ascendant", 600000),
        new Rank("Mythical", 650000),
        new Rank("Celestial", 700000),
        new Rank("Epic", 750000),
        new Rank("Legendary", 800000),
        new Rank("Divine", 850000),
        new Rank("Transcendent", 900000),
        new Rank("Titan", 950000),
        new Rank("Apex", 1000000)
    };

    public static void CheckRank()
    {
        foreach (Rank rank in Ranks)
        {
            if (Goal.GetTotalScore() >= rank.PointsRequired)
            {
                Console.WriteLine($"Congratulations! You have reached the rank of {rank.Name}");
            }
            else
            {
                break;
            }
        }
    }
    
    public static void DisplayProgress()
    {
        int totalScore = Goal.GetTotalScore();
        Rank currentRank = null;
        Rank nextRank = null;

        for (int i = 0; i < Ranks.Length; i++)
        {
            if (totalScore >= Ranks[i].PointsRequired)
            {
                currentRank = Ranks[i];

                if (i == Ranks.Length - 1)
                {
                    Console.WriteLine($"Congratulations! You have reached the highest rank of {currentRank.Name}");
                    return;
                }
            }
            else
            {
                nextRank = Ranks[i];
                break;
            }
        }

        int progress = (totalScore - currentRank.PointsRequired) * 100 / (nextRank.PointsRequired - currentRank.PointsRequired);

        Console.WriteLine($"Your progress towards the next rank:");
        Console.WriteLine($"Current Rank: {currentRank.Name}");
        Console.WriteLine($"Progress: {progress}%");
        Console.WriteLine($"Next Rank: ??"); // Hidden rank name
    }

}
