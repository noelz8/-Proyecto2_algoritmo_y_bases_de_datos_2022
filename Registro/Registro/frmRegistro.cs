//using System.Data.OleDb;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Registro
{
   
    public partial class frmRegister : Form
    {
        
        public class Usuarios
        {
            //Esta clase segun las guias es la que debe de estar para que guarde en el JSON
            
            public string? Nombre { get; set; }
            public string? Apellidos { get; set; }
            public string? Edad { get; set; }
            public string? Usuario { get; set; }
            public string? Password { get; set; }
            public string? CPassword { get; set; }




        }
        public class JsonOperation
        {
            public static void Serialize(Usuarios usuarios)
            {
                File.WriteAllText("registros.json", JsonConvert.SerializeObject(usuarios));
            }
        }

        public frmRegister()
        {
            InitializeComponent();
           


        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
       

        // aqui hay que hacer que al apredar el boton registre lo de las cajas de texto en json. El texto de las cajas es lo que tiene como formato .Text al final
        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text==""&& txtUsuario.Text == "" && txtApellidos.Text == "" && txtEdad.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
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
                System.IO.File.WriteAllText(@"C:\Users\hp\Desktop\I semestre 2022\progrmacion\Proyecto 2\Registro\Registro\bin\Debug\net6.0-windows\registros.json", json);


                //ESTO SIRVE

                //File.Create(@"registros.json"); 
                //Crea el archivo
                // serialize JSON to a string and then write string to a file
                //File.WriteAllText(@"C:\Users\hp\Desktop\I semestre 2022\progrmacion\Proyecto 2\Registro\Registro\bin\Debug\net6.0-windows\registros.json", JsonConvert.SerializeObject(_usuarios));

                //// serialize JSON directly to a file
                //using (StreamWriter file = File.CreateText(@"C:\Users\hp\Desktop\I semestre 2022\progrmacion\Proyecto 2\Registro\Registro\bin\Debug\net6.0-windows\registros.json"))
                //{
                //    JsonSerializer serializer = new JsonSerializer();
                //    serializer.Serialize(file,_usuarios);
                //}
                //

                txtNombre.Text = "";
                txtUsuario.Text = "";
                    txtApellidos.Text = "";
                    txtEdad.Text = "";
                    txtPassword.Text = "";
                    txtComPassword.Text = "";




                MessageBox.Show("Registro Completo, disfruta", "Incia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmLogin().Show();
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

       

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
  
}
