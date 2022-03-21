using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMangas.Entities
{
    public class ListManga
    {
        public string Name { get; set; }
        public int Year { get; set; }


        public ListManga(string name = " " , int year = 0000)
        {
            Name = name;
            Year = year;

        }
       
    }
}
