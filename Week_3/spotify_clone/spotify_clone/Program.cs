namespace spotify_clone;
class Program
{
    static void Main(string[] args)
    {
        var song1 = new Song("Sarki Adi", "Sarki Bestecisi", "Sanatci",null);
        var song2 = new Song("Sarki Adi2", "Sarki Bestecisi2", "Sanatci2", "Producer");
        var song3 = new Song("Sarki Adi3", "Sarki Bestecisi3", "Sanatci3", "Producer2");
        var song4 = new Song("Sarki Adi4", "Sarki Bestecisi4", "Sanatci4", "Producer3");

        var playlist1 = new Playlist(song1);
        playlist1.AddSong(song2);
        playlist1.AddSong(song3);
        playlist1.AddSong(song4);

        Console.WriteLine("BEFORE SHUFFLE");
        Console.WriteLine(playlist1.GetSongs());

        Console.WriteLine("aFTER SHUFFLE");
        playlist1.ShuffleSongs();
        Console.WriteLine(playlist1.GetSongs());
        Console.ReadLine();

        NotepadService notepadService = new();
        notepadService.WriteToNotePad(playlist1.GetSongs());
    }
}