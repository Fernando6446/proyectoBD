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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registro reg = new Registro();
            reg.ShowDialog();
            this.Visible = true;
        }

        public void clearComponents()
        {
            this.txt_pass.Text = "";
            this.txt_usuario.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControllerDatabase.UserController user_controller = new ControllerDatabase.UserController();
            if (txt_usuario.Text.ToLower() == "admin")
            {
                if (user_controller.userExist(txt_usuario.Text, txt_pass.Text))
                {
                    this.Visible = false;
                    AdminDash adminDash = new AdminDash();
                    adminDash.ShowDialog();
                    this.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este usuario no existe lol");
                    this.clearComponents();
                }
            }
            else
            {
                if (user_controller.userExist(txt_usuario.Text, txt_pass.Text))
                {
                    this.Visible = false;
                    GenresGallery genresGallery = new GenresGallery();
                    genresGallery.ShowDialog();
                    this.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este usuario no existe lol");
                    this.clearComponents();
                }
            }

        }
    }
}
