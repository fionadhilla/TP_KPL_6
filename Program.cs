using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int increaseAmount)
    {
        playCount += increaseAmount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public static void Main(string[] args)
    {
        string namaPraktikan = "FIONADHILLA";
        string judulVideo = $"Tutorial Design By Contract - {namaPraktikan}";

        SayaTubeVideo video = new SayaTubeVideo(judulVideo);

        video.IncreasePlayCount(10);

        video.PrintVideoDetails();
    }
}
