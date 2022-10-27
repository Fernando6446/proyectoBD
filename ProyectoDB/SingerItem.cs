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
    public partial class SingerItem : UserControl
    {
        public SingerItem(string name)
        {
            lbl_name.Text = name;
            InitializeComponent();
        }
        private void SingerItem_MouseDown(object sender, MouseEventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = SystemColors.ControlDark;
        }

        private void SingerItem_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = SystemColors.ControlDarkDark;
        }

        private void SingerItem_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = SystemColors.ControlDark;

        }


        public void setImage()
        {
            this.BackgroundImage = Image.FromFile("./imgs/Generos/" + lbl_name.Text + ".jpg");
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
