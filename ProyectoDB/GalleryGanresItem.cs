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
        }

        private void GalleryGanresItem_MouseDown(object sender, MouseEventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = SystemColors.ControlDark;
        }

        private void GalleryGanresItem_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = SystemColors.ControlDarkDark;
        }

        private void GalleryGanresItem_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = SystemColors.ControlDark;

        }
    }
}
