using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentNullException("Judul video tidak boleh null.");
        if (title.Length > 100)
            throw new ArgumentOutOfRangeException("Panjang judul video maksimal 100 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int increaseAmount)
    {
        if (increaseAmount <= 0)
            throw new ArgumentOutOfRangeException("Penambahan play count minimal 1.");
        if (increaseAmount > 10000000)
            throw new ArgumentOutOfRangeException("Penambahan play count maksimal 10.000.000.");
        //playCount += increaseAmount;

        try
        {
            checked
            {
                playCount += increaseAmount;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Terjadi overflow pada play count: {ex.Message}");
        }
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

        //SayaTubeVideo video = new SayaTubeVideo(judulVideo);

        //video.IncreasePlayCount(10);
        //video.PrintVideoDetails();

        try
        {
            SayaTubeVideo video = new SayaTubeVideo(judulVideo);

            video.IncreasePlayCount(12);
            video.PrintVideoDetails();
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
