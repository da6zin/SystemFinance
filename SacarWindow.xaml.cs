using System.Windows;

namespace SystemFinance
{
    public partial class SacarWindow : Window
    {
        private double saldo;
        public double NovoSaldo { get; private set; }

        public SacarWindow(double saldoInicial)
        {
            InitializeComponent();
            this.saldo = saldoInicial;
            this.NovoSaldo = saldoInicial;
        }

        private void Confirmar_Button_Click(object sender, RoutedEventArgs e)
        {
            double valorSacado = double.Parse(Text_Box.Text);


            if (saldo - valorSacado >= 0)
            {
                this.NovoSaldo = saldo - valorSacado;
                MessageBox.Show($"Saldo de R${valorSacado}, retirado");
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Saldo insuficiente para este saque.");
            }
        }

        private void Cancelar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }


    }
}
