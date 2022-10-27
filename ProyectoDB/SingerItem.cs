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

namespace ProyectoDB
{
    public partial class SingerItem : UserControl
    {
        public templates.Singer singer;
        public SingerItem(Singer singer)
        {
            this.singer = singer;
            InitializeComponent();
            this.setImage();
        }
        public void setImage()
        {
            lbl_name.Text = this.singer.name;
            this.BackgroundImage = Image.FromFile("./imgs/Cantantes/" + this.singer.name + ".jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void SingerItem_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            PaginaArtista pa = new PaginaArtista(this.singer);
            pa.ShowDialog();
            this.Visible =true;
        }
    }
}
