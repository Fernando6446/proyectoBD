using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templates
{
    public class Genre
    {
        public int id;
        public string name;

        public Genre(int id, string n)
        {
            this.id = id;
            this.name = n;
        }
    }
}
