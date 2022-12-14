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
    public partial class GalleryGanresItem : UserControl
    {
        public GalleryGanresItem(string gente)
        {
            InitializeComponent();
            this.lbl_name.Text = gente;
            this.setImage();
        }

        private void GalleryGanresItem_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        private void GalleryGanresItem_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }


        public void setImage()
        {
            this.BackgroundImage = Image.FromFile("./imgs/Generos/" + lbl_name.Text + ".jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void GalleryGanresItem_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            SingersGallery sg = new SingersGallery();
            sg.ShowDialog();
        }
    }
}
