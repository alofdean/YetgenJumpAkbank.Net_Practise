using System;
namespace spotify_clone
{
	public class Playlist
	{
		public Guid Id { get; set; }
		private List<Song> Songs { get; set; }

		public Playlist(Song firstSong)
		{
            Songs = new List<Song>();
            AddSong(firstSong);
		}

		public void AddSong(Song song)
		{
			if (song != null)
				Songs.Add(song);
		}

		public string GetSongs()
		{

			return string.Join("\n", Songs.Select(song => $"{song.Title} - {song.Composer}"));
		}

		public void ShuffleSongs()
		{
			int songCount = Songs.Count;
            Random random = new();

            while (songCount > 0)
			{
				songCount--;
				Song song = Songs[songCount];


				int randomIndex = random.Next(songCount);

				Songs[songCount] = Songs[randomIndex];

				Songs[randomIndex] = song;
			}
		}
	
	}
}

