namespace Combustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double recorrido = double.Parse(Distancia.Text);
            double rendimiento = double.Parse(Rendimiento.Text);

            double resultado = recorrido / rendimiento;


            Total.Text = resultado.ToString();

        }
    }
}
