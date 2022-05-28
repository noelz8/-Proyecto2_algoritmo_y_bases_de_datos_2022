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
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Converters;

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
            public Root[] Property1 { get; set; }
        }

        public class Root
        {
            [JsonProperty("Nombre")]
            public string Nombre { get; set; }

            [JsonProperty("Apellidos")]
            public string Apellidos { get; set; }

            [JsonProperty("Edad")]
            public string Edad { get; set; }

            [JsonProperty("Usuario")]
            public string Usuario { get; set; }

            [JsonProperty("Password")]
            public string Password { get; set; }

            [JsonProperty("CPassword")]
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


        public class RootConverter : CustomCreationConverter<Root>
        {
            public override Root Create(Type objectType)
            {
                return new Root();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\Personal\Desktop\Trabajos del Tec\3 y 4 semstre\Datos\Repositorios de datos\-Proyecto2_algoritmo_y_bases_de_datos_2022\Prueba2\Prueba2\bin\Debug\registros.json";
            string datos = File.ReadAllText(path);

            Root cosa = JsonConvert.DeserializeObject<Root>(path, new RootConverter());

            





            if (txtUsuario.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Llene los espacios", "inicio Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsuario.Text == "admin"  && txtPassword.Text== "admin")
            {
                new reproductir().Show();
                this.Hide();
            }


        }
    }
}
