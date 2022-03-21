using Devices.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMangas.Entities
{
    class Printer : IPrinter
    {
        public string NameManga { get; set; }

        List<ListManga> lists = new List<ListManga>();

        public void PrintManga()
        {
            Console.WriteLine("Which manga you want to read? ");
            string nameManga = Console.ReadLine();
            NameManga = nameManga;

            ListManga result = lists.Find(name => name.Name == nameManga);

            if ( nameManga != result.Name || nameManga == null)
            {
                throw new MangaInexistException("erro");
            }
            else
            {
                Console.WriteLine("Print your manga...");
            }
        }

    }
}
