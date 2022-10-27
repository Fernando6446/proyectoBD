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
            this.fillData();
        }
        public void fillData()
        {
            ControllerDatabase.SingerController singerController = new ControllerDatabase.SingerController();
            List<templates.Singer> singers = singerController.getSingers();
            foreach (templates.Singer singer in singers)
            {
                container.Controls.Add(new SingerItem(singer));
            }
        }
    }
}
