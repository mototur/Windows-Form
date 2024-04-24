namespace Calculadora_de_Viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double origen = double.Parse(PuntodeOrigen.Text);
            double velocidad = double.Parse(PuntoDestino.Text);


            double tiempocalculado = origen / velocidad;

            MessageBox.Show("Tiempo estimado del viaje: " + tiempocalculado.ToString() + " horas", "Resultado" );      }
    }
}
