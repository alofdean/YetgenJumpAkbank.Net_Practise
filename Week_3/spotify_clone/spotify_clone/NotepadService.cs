using System;
namespace spotify_clone
{
	public class NotepadService
	{
		public void WriteToNotePad(string data)
		{
			File.WriteAllText("/Users/alofdean/Desktop/test.txt", data);
			Console.WriteLine("Data Saved Successfully");
		}
	}
}

