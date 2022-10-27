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
        public string name;
        public SingerItem(string name)
        {
            this.name = name;
            InitializeComponent();
            this.setImage();
        }
        public void setImage()
        {
            this.BackgroundImage = Image.FromFile("./imgs/Cantantes/" + name + ".jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
