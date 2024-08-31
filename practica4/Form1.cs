namespace practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombres = tbNombres.Text;
            String apellidos = tbApellidos.Text;
            String telefono = tbTelefono.Text;
            String edad = tbEdad.Text;
            String estatura = tbEstatura.Text;
            String genero = "";

            if (rbMujer.Checked)
            {
                genero = rbMujer.Text;
            }
            else if (rbHombre.Checked)
            {
                genero = rbHombre.Text;
            }

            String datos = $"nombres : {nombres} \r\napellidos: {apellidos}\r\nedad: {edad}\r\nestatura: {estatura}\r\ntelefono: {telefono}\r\ngenero: {genero}\r\n";

            String rutadearchivo = "C:\\Users\\lenovo\\source\\repos\\practica4\\datos.txt";

            using (StreamWriter writer = new StreamWriter(rutadearchivo, true))
            {
                writer.WriteLine(datos);
            }

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
    }
}
