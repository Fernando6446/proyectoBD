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
        public int genre;
        public string awards;

        public Singer(int id, string name, DateTime birth_date, DateTime start, string country, string ocup, int genre,  string awards)
        {
            this.id = id;
            this.name = name;
            this.birth_date = birth_date;
            this.start = start;
            this.country = country;
            this.ocup = ocup;
            this.genre = genre;
            this.awards = awards;
        }
    }
}
