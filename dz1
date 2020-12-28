// Студент: Клюс Илья
// Группа: ИУ6-71Б
// Вариант: F2
using System;


namespace Music
{
    public class Artist
    {
        public string Name, Surname;

        public Artist()
        { 
            Name = "Unknown"; 
            Surname = "Unknown";
            Console.WriteLine("Name: {0}\nSurname: {1}\n", Name, Surname);
        }
        public Artist(string name,string surname)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("Name: {0}\nSurname: {1}\n", Name, Surname);
        }
        public string Represent()
        {
            string author = Name + ' ' + Surname;
            return author;
        }
    }
    public class Album
    {
        public string Name;
        public int Year;

        public Album()
        {
            Name = "Unknown";
            Year =  0;
            Console.WriteLine("Title: {0}\nYear: {1}\n", Name, Year);
        }
        public Album(string name, int year)
        {
            Name = name;
            Year = year;
            Console.WriteLine("Title: {0}\nYear: {1}\n", Name, year);
        }
        public string Represent()
        {
            string album = Name + " Year: " + Year.ToString();
            return album;
        }
    }
    public class Song
    {
        public string Name, Gener;
        public int Year;
        public Artist Author, Name1, Name2;
        public Album Album;
        public Song()
        {
            Name = "Unknown";
            Gener = "Unknown";
            Year = 0;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\n", Name, Gener,"Неизвесто");
        }
        public Song(string name,string gener, int year)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\n", Name, Gener, Year);
        }
        public Song(string name, string gener, int year, Artist author)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthor: {3}\n", Name, Gener, Year, Author.Represent());

      }
        public Song(string name, string gener, int year, Artist name1, Artist name2)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Name1 = name1;
            Name2 = name2;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthors: {3}, {4}\n", Name, Gener, Year, Name1.Represent(), Name2.Represent());

        }
        public Song(string name, string gener, int year, Artist author, Artist name1, Artist name2)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Name1 = name1;
            Name2 = name2;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthors: {3}, {4}, {5}\n", Name, Gener, Year, Author.Represent(), Name1.Represent(), Name2.Represent());

        }
        public Song(string name, string gener, int year,Album album)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Album = album;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAlbum: {3}\n", Name, Gener, Year, Album.Represent()); ;
        }
        public Song(string name, string gener, int year, Artist author, Album album)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Album = album;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthor: {3}\nAlbum: {4}\n", Name, Gener, Year, Author.Represent(), Album.Represent());

        }
        public Song(string name, string gener, int year, Artist name1, Artist name2, Album album)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Name1 = name1;
            Name2 = name2;
            Album = album;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthors: {3}, {4}\nAlbum: {5}\n", Name, Gener, Year, Name1.Represent(), Name2.Represent(), Album.Represent());

        }
        public Song(string name, string gener, int year, Artist author, Artist name1, Artist name2, Album album)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Name1 = name1;
            Name2 = name2;
            Album = album;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthors: {3}, {4}, {5}\nAlbum: {6}\n", Name, Gener, Year, Author.Represent(), Name1.Represent(), Name2.Represent(), Album.Represent());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Artist led_zeppelin = new Artist("Led", "Zeppelin");
            Album lz_4 = new Album("Led Zeppelin IV", 2020);
            Song stairway_to_heaven = new Song("Stairway to Heaven","Rock", 1971, led_zeppelin, lz_4);

           Console.ReadKey();
        }
    }
}