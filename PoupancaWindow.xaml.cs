using System.Windows;

namespace SystemFinance
{
    public partial class PoupancaWindow : Window
    {
        private double saldo;

        public PoupancaWindow(double saldo)
        {
            InitializeComponent();
            this.saldo = saldo;
        }

        private void Simular_Click(object sender, RoutedEventArgs e)
        {
            double rendimento = saldo * 0.005; // 0,5%
            MessageBox.Show($"Seu rendimento estimado é R$ {rendimento:F2}");
        }
    }
}
