using System.Windows;

namespace SystemFinance
{
    public partial class TransferirWindow : Window
    {
        private double saldo;
        public double novoSaldo { get; set; }

        public TransferirWindow(double saldoInicial)
        {
            InitializeComponent();
            this.saldo = saldoInicial;
            this.novoSaldo = saldoInicial;
        }

        private void Confirmar_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Valor_TextBox.Text) &&
                !string.IsNullOrWhiteSpace(Nome_TextBox.Text) &&
                double.TryParse(Valor_TextBox.Text, out double valorTransferido) &&
                valorTransferido > 0)
            {
                string nomeDestinatario = Nome_TextBox.Text;
                if (saldo - valorTransferido >= 0)
                {
                    this.novoSaldo = saldo - valorTransferido;
                    MessageBox.Show($"Transferência de R${valorTransferido} para {nomeDestinatario} realizada com sucesso.");
                    this.DialogResult = true;
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente para esta transferência.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
            }
        }

        private void Cancelar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void Valor_TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Nome_TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
