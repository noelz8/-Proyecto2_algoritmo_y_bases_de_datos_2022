using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using System.Collections.Generic;


namespace Registro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();


            
        }
        public void LoadJson()
        {
            using (StreamReader r= new StreamReader("registros.json"))
            {
                string json =r.ReadToEnd();
                List<Usuarios> usuarios = Newtonsoft.Json.JsonConverter.DeserializeObject<List<Usuarios>>(json);

            }
        }

        class Usuarios
        {
            public Usuarios(string nombre, string apellidos, string edad, string usuario, string password, string cpassword)
            {
                this.Nombre = nombre;
                this.Apellidos = apellidos;
                this.Edad = edad;
                this.Usuario = usuario;
                this.Password = password;
                this.CPassword = cpassword;
            }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Edad { get; set; }
            public string Usuario { get; set; }
            public string Password { get; set; }
            public string CPassword { get; set; }
        }






            private void btnLogin_Click(object sender, EventArgs e) //aqui hay que hacer que lea el JSON y verifique que los datos ingresados estan bien
        {
            //con.Open();
            //string login = "SELECT * FROM tbl_users WHERE usuario= '" + txtUsuario.Text + "' and contraseña= '" + txtPassword.Text + "'";
            //cmd = new OleDbCommand(login,con);
            ////OleDbDataReader dr = cmd.ExecuteReader();
            //if (dr.Read() == true)

            {
                new frmholder().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Intenta de nuevo o registrate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtUsuario.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtUsuario.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                
            }
            else
            {
                txtPassword.PasswordChar = '*';
               
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
