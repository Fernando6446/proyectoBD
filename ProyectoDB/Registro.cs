using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerDatabase;

namespace ProyectoDB
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            ControllerDatabase.UserController userController = new ControllerDatabase.UserController();
            userController.createUser(txt_usuario.Text, txt_correo.Text, txt_tel.Text, txt_pass.Text);
        }
    }
}
