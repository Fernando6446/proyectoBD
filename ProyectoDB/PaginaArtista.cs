using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using templates;
using ControllerDatabase;

namespace ProyectoDB
{
    public partial class PaginaArtista : Form
    {
        public Singer singer;
        public PaginaArtista(Singer singer)
        {
            this.singer = singer;
            InitializeComponent();
            this.fillData();
        }

        public void fillData()
        {
            lbl_name.Text = this.singer.name;
            ControllerDatabase.GenreController gcontroller = new ControllerDatabase.GenreController();
            List<Genre> genres = gcontroller.getGenres();
            foreach(Genre genre in genres)
            {
                if(genre.id == this.singer.genre)
                {
                    label_genero.Text = genre.name;
                }
            }
            label_pais.Text = this.singer.country;
            label_premios.Text = this.singer.awards;
            pic_imagen.Image = Image.FromFile("./imgs/Cantantes/" + this.singer.name + ".jpg");
        }
    }
}
