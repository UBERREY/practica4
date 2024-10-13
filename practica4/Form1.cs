using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbNombres.TextChanged += validarNombre;
            tbApellidos.TextChanged += validarApellido;
            tbTelefono.TextChanged += validarTelefono;
            tbEdad.TextChanged += validarEdad;
            tbEstatura.TextChanged += validarEstatura;
        }

        string DBConection = "Server=localhost;Port=3306;Database=programacionavanzada;Uid=root;Pwd=Migato_105;";


        void insertRegistry(string nombres, string apellidos, int edad, float estatura, long celular, string genero)
        {
            using (MySqlConnection connection = new MySqlConnection(DBConection))
            {
                connection.Open();

                string insertQuery = "insert into registros (nombres, apellidos, edad, estatura, celular, genero) " +
                    "values (@nombres, @apellidos, @edad, @estatura, @celular, @genero)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@nombres", nombres);
                    command.Parameters.AddWithValue("@apellidos", apellidos);
                    command.Parameters.AddWithValue("@celular", celular);
                    command.Parameters.AddWithValue("@estatura", estatura);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@genero", genero);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            String nombres = tbNombres.Text;
            String apellidos = tbApellidos.Text;
            long celular = long.Parse(tbTelefono.Text);
            int edad = int.Parse(tbEdad.Text);
            float estatura = float.Parse(tbEstatura.Text);
            String genero = "";

            if (rbMujer.Checked)
            {
                genero = rbMujer.Text;
            }
            else if (rbHombre.Checked)
            {
                genero = rbHombre.Text;
            }

            String datos = $"nombres : {nombres} \r\napellidos: {apellidos}\r\nedad: {edad}\r\nestatura: {estatura}\r\ntelefono: {celular}\r\ngenero: {genero}\r\n";

            String rutadearchivo = "C:\\Users\\lenovo\\source\\repos\\practica4\\datos.txt";

            using (StreamWriter writer = new StreamWriter(rutadearchivo, true))
            {
                writer.WriteLine(datos);
            }

            insertRegistry(nombres, apellidos, edad, estatura, celular, genero);

            MessageBox.Show("Datos Guardados con Exito");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            tbNombres.Clear();
            tbApellidos.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            tbEstatura.Clear();
        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }
        private void validarNombre(object sender, EventArgs e)
        {
            if (!EsTextoValido(tbNombres.Text))
            {
                MessageBox.Show("ingrese un nombre valido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombres.Clear();
            }
        }

        private void validarApellido(object senter, EventArgs e)
        {
            if (!EsTextoValido(tbApellidos.Text))
            {
                MessageBox.Show("Ingrese un apellido valido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbApellidos.Clear();
            }
        }



        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private void validarEdad(object senter, EventArgs e)
        {
            if (!EsEnteroValido(tbEdad.Text))
            {
                MessageBox.Show("ingrese una edad valida", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEdad.Clear();
            }
        }


        private void validarEstatura(object senter, EventArgs e)
        {
            if (!EsDecimalValido(tbEstatura.Text))
            {
                MessageBox.Show("Ingrese una estatura valida (en metros)", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEstatura.Clear();
            }
        }
        private bool EsDecimalValido(string valor)
        {
            float resultado;
            return float.TryParse(valor, out resultado);
        }

        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string input = textbox.Text;
            if (textbox.Text.Length == 10 && EsEnteroValidoDe10Digitos(textbox.Text))
            {
                textbox.BackColor = Color.Green;
            }
            else
            {
                textbox.BackColor = Color.Red;
            }

        }
        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }
        private void tbNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEstatura_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
