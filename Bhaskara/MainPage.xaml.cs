namespace Bhaskara
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void btCalcularRaizes_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(valueA.Text);
            double b = Convert.ToDouble(valueB.Text);
            double c = Convert.ToDouble(valueC.Text);

            double delta = (b * b) - 4 * a * c;

            if (delta < 0)
            {
                lbResultado.Text = "A equação não possui raízes reais";
            }
            else if (delta == 0)
            {
                double raiz = -b / (2 * a);
                lbResultado.Text = String.Format("x = {0:f2}", raiz);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                lbResultado.Text = String.Format("x¹ = {0:f2}\nx² = {1:f2}", x1, x2);
            }
        }
    }
}
