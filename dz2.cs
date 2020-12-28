// Студент: Клюс Илья
// Группа: ИУ6-71Б
// Вариант: F2

using System;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Music
{
    public class Artist
    {
        public string Name { get; set; }
        public string Surname {get; set;}

    }
    public class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Gener { get; set; }
        public int Year { get; set; }
        public Artist[] Authors { get; set; }
        public Album Album_name { get; set; }

}
    class Program
    {
        static void Main(string[] args)
        {
            Artist bob_dylan = new Artist
            {
                Name = "Bob",
                Surname = "Dylan"

            };
            Album hw = new Album
            {
                Name = "Highway 61 Revisited",
                Year = 1965,
            };
            Song LFL = new Song
            {
                Name = "Like A Rolling Stone",
                Year = 1965,
                Gener = "Rock",
                Authors = new Artist[] { bob_dylan },
                Album_name = hw

            };

            
            string json = JsonSerializer.Serialize<Song>(LFL);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}