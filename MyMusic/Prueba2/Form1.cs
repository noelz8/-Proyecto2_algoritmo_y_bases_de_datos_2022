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

namespace Prueba2
{
    public partial class Form1 : Form
    {

        public class Usuarios
        {
            //Esta clase segun las guias es la que debe de estar para que guarde en el JSON

            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Edad { get; set; }
            public string Usuario { get; set; }
            public string Password { get; set; }
            public string CPassword { get; set; }




        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" && txtUsuario.Text == "" && txtApellidos.Text == "" && txtEdad.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Llene los espacios", "registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == txtComPassword.Text)
            {




                List<Usuarios> _usuarios = new List<Usuarios>();
                _usuarios.Add(new Usuarios()

                {

                    Nombre = txtNombre.Text,
                    Usuario = txtUsuario.Text,
                    Apellidos = txtApellidos.Text,
                    Edad = txtEdad.Text,
                    Password = txtPassword.Text,
                    CPassword = txtComPassword.Text
                });




                string json = JsonConvert.SerializeObject(_usuarios.ToArray());

                //write string to file
                System.IO.File.WriteAllText(@"C:\Users\Personal\Desktop\Trabajos del Tec\3 y 4 semstre\Datos\Git hub\p\-Proyecto2_algoritmo_y_bases_de_datos_2022\MyMusic\Prueba2\bin\Debug\registros.json", json);

                txtNombre.Text = "";
                txtUsuario.Text = "";
                txtApellidos.Text = "";
                txtEdad.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";




                MessageBox.Show("Registro Completo, disfruta", "Incia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new reproductir().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseñas no son iguales", "registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsuario.Focus();
        }
    }
}
