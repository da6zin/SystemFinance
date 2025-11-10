using System.Windows;

namespace SystemFinance
{
    public partial class SacarWindow : Window
    {
        private double saldo;

        public SacarWindow(double saldo)
        {
            InitializeComponent();
            this.saldo = saldo;
        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtValor.Text, out double valor) && valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                MessageBox.Show($"Saque de R$ {valor:F2} realizado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Valor inválido ou saldo insuficiente.");
            }
        }
    }
}
