using Devices.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMangas.Entities
{
    class Mangas : IPrinter, IScanner
    {
        public string Option { get; set; }
        public string NameManga { get; set; }

        List<ListManga> lists = new List<ListManga>();
        public void SearchManga()
        {
            Console.WriteLine("Mangas for read. For to choose a genre select shoujo, seinen or shounen: ");
            string option = Console.ReadLine();
            Option = option;

            if (option == "shoujo")
            {
                lists.Add(new ListManga("Nana", 2000));
                lists.Add(new ListManga("Versailles no Bara", 1970));

                for (int i = 0; i < lists.Count; i++)
                {
                    Console.WriteLine(lists[i].Name + " " + lists[i].Year);
                }
            }
            else if (option == "seinen")
            {
                lists.Add(new ListManga("Berserk", 1980));
                lists.Add(new ListManga("Jojo", 1980));
                for (int i = 0; i < lists.Count; i++)
                {
                    Console.WriteLine(lists[i].Name + " " + lists[i].Year);
                }
       
            }
            else if (option == "shounen")
            {
                lists.Add(new ListManga("One Piece", 1999));
                lists.Add(new ListManga("HxH", 1997));
                for (int i = 0; i < lists.Count; i++)
                {
                    Console.WriteLine(lists[i].Name + " " + lists[i].Year);
                }
            }
            else
            {
                throw new OptionInexistException("Erro, incorrect option. " +
                    "Please select some three options compliant with suggestions.");
            }
        }
        public void PrintManga()
        {

            Console.WriteLine("Which manga you want to read? ");
            string nameManga = Console.ReadLine();
            NameManga = nameManga;

            ListManga result = lists.Find(name => name.Name == nameManga);

            if (result == null)
            {

                throw new MangaInexistException("Erro. This manga doesn't exist.");
            }
            else
            {
                Console.WriteLine("Print your manga...");
            }
        }


        public string Scan()
        {
            return "Here is your manga: " + NameManga;
        }
    }
}
