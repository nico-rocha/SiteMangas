using Devices.Exceptions;
using SiteMangas.Entities;
using System;

namespace Devices
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Mangas manga = new Mangas();
                manga.SearchManga();
                manga.PrintManga();

                Scanner scanManga = new Scanner();
                Console.WriteLine(scanManga.Scan());
                Console.WriteLine(manga.Scan());
            }
            catch(OptionInexistException e)
            {
                Console.WriteLine("Error in option." + e.Message);
            }
            catch(MangaInexistException e)
            {
                Console.WriteLine("Selection error in manga." + e.Message);
            }

        }
    }
}
