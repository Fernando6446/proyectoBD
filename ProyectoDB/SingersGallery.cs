using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class SingersGallery : Form
    {
        public SingersGallery()
        {
            InitializeComponent();
        }
        public void fillData()
        {
            ControllerDatabase.GenreController genreController = new ControllerDatabase.GenreController();
            List<templates.Genre> genres = genreController.getGenres();
            foreach (templates.Genre genre in genres)
            {
                container.Controls.Add(new GalleryGanresItem(genre.name));
            }
        }
    }
}
