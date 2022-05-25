using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using System.Text.Json.Serialization;
using System.IO;

namespace Prueba2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       


        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Edad { get; set; }
            public string Usuario { get; set; }
            public string Password { get; set; }
            public string CPassword { get; set; }
        }


        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";

            txtUsuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 _usuarios = JsonConvert.DeserializeObject<Class1>(File.ReadAllText(@"D:\registros.json"));
            //Class1 _usuarios = JsonConvert.DeserializeObject<Class1>(@"registros.json");
            string user = _usuarios.Usuario;
            string passw = _usuarios.Password;

            if (txtUsuario.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Llene los espacios", "inicio Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsuario.Text == user && txtPassword.Text == passw)
            {
                new reproductir().Show();
                this.Hide();
            }


        }
    }
}
