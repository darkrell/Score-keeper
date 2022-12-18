namespace Score_keeper.Data;

public class ScorePageModel
{
    public string Name { get; set; } = DateTime.Now.ToString("g");
    public int PlayersCount { get; set; } = 2;

    public int ScoreHightChangeValue { get; set; } = 10;
    public int ScoreChangeValue { get; set; } = 5;
    public int[] Scores { get; set; } = new int[20];
}