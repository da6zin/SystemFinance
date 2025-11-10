using System.Windows;

namespace SystemFinance
{
    public partial class TransferirWindow : Window
    {
        private double saldo;

        public TransferirWindow(double saldo)
        {
            InitializeComponent();
            this.saldo = saldo;
        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtValor.Text, out double valor) && valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                MessageBox.Show($"Transferência de R$ {valor:F2} realizada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Valor inválido ou saldo insuficiente.");
            }
        }
    }
}
