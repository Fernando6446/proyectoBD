using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templates
{
    public class Singer
    {
        public int id;
        public string name;
        public DateTime birth_date;
        public DateTime start;
        public string country;
        public string ocup;
        public string genre;
        public string instruments;
        public string awards;
        public string image;

        public Singer(int id, string name, DateTime birth_date, DateTime start, string country, string ocup, string genre, string instruments, string awards, string image)
        {
            this.id = id;
            this.name = name;
            this.birth_date = birth_date;
            this.start = start;
            this.country = country;
            this.ocup = ocup;
            this.genre = genre;
            this.instruments = instruments;
            this.awards = awards;
            this.image = image;
        }
    }
}
