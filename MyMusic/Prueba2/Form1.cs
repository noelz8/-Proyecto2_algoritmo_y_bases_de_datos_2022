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
        // se crea la clase Usuario para determinar los elementos que se van a recopilar mediante el registro
        //Usando get y set para obtener los datos de las text boxes y escribirlo en el archvo JSON
        public class Usuarios
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
        //Boton de registro
        //al darle click encima primero verifica que todos los campos este llenos, en caso de no estarlo envia un mensaje diciendo eso
        private void button1_Click(object sender, EventArgs e)
        {
            //verifica que los text boxes tengan escrito algo
            if (txtNombre.Text == "" && txtUsuario.Text == "" && txtApellidos.Text == "" && txtEdad.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Llene los espacios", "registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);//envia el mensaje de error si no estan llenos
            }

            else if (txtPassword.Text == txtComPassword.Text)//se declara que pasa si si esta lleno
            {




                List<Usuarios> _usuarios = new List<Usuarios>();// se forma una lista donde se van almacenar los datos registrados por el usuario
                

                JsonSerializer serializer = new JsonSerializer();//se declara esta funcion para poder serializar la lista a JSON
                //Se usa el string path para darle la ruta donde se encuentra el archivo JSON, en este caso "registros.json"
                string path = @"C:\Users\hp\Documents\GitHub\-Proyecto2_algoritmo_y_bases_de_datos_2022\MyMusic\Prueba2\bin\Debug\registros.json";
                //string path = @"D:\registros.json";


                if (System.IO.File.Exists(path))//Comprueba si el archivo existe en el sistema
                {
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(path))//se usa la funcion de la libreria de System para que este leyendo el archivo
                    {
                        Newtonsoft.Json.JsonReader jsonReader= new Newtonsoft.Json.JsonTextReader(reader);//funcion hecha para leer el archivo
                        _usuarios= serializer.Deserialize<List<Usuarios>>(jsonReader);
                        
                    }
                }

                using (System.IO.StreamWriter file=new System.IO.StreamWriter(path, false)) //usnado el system writer para escribir los datos en el JSON
                {

                    _usuarios.Add(new Usuarios()//se solicita que se añada una nueva lista a _usuarios, la cual es una lista

                    {
                        //se declara el valor que tendran los atributos del JSON, en este caso el texto escrito en los text Boxes
                        Nombre = txtNombre.Text,
                        Usuario = txtUsuario.Text,
                        Apellidos = txtApellidos.Text,
                        Edad = txtEdad.Text,
                        Password = txtPassword.Text,
                        CPassword = txtComPassword.Text
                    });

                    serializer.Serialize(file, _usuarios);//se serializa la lista _usuarios a un formato JSON
                    
                }


                //write string to file
                System.IO.File.WriteAllText(@"C:\Users\Personal\Desktop\Trabajos del Tec\3 y 4 semstre\Datos\Git hub\p\-Proyecto2_algoritmo_y_bases_de_datos_2022\MyMusic\Prueba2\bin\Debug\registros.json", json);

                //string json = JsonConvert.SerializeObject(_usuarios.ToArray());


                ////write string to file
                //System.IO.File.WriteAllText(@"C:\Users\hp\Desktop\I semestre 2022\progrmacion\Proyecto 2\Prueba2\Prueba2\bin\Debug\registros.json", json);
                //Luego de haber escrito, los espacios vuelven a estar vacis
                txtNombre.Text = "";
                txtUsuario.Text = "";
                txtApellidos.Text = "";
                txtEdad.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";




                MessageBox.Show("Registro Completo, disfruta", "Incia", MessageBoxButtons.OK, MessageBoxIcon.Information);//confirma que se registro correctamente
                new reproductir().Show();//muestra el form del reproductor de musica
                this.Hide();
                //cierra el form actual
            }
            else
            {
                MessageBox.Show("Contraseñas no son iguales", "registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);//en caso contrario envia error y deja en blanco los espacios de las contraseña
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//el checkbox para poder ver la contraseña
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

        private void button2_Click(object sender, EventArgs e)//El boton de limpiar, lo que hace es quitar lo que haya escrito en los textboxes
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsuario.Focus();
        }

        private void label9_Click(object sender, EventArgs e)//Al tocar el label cambia a login directamente
        {
            new Login().Show();
            this.Hide();
        }
    }
}
