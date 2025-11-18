using System.Windows;

namespace SystemFinance
{
    public partial class PoupancaWindow : Window
    {
        private double saldoAtual;
        public double NovoSaldo { get; set; }

        public PoupancaWindow(double saldoInicial)
        {
            InitializeComponent();
            saldoAtual = saldoInicial;
            this.NovoSaldo = saldoInicial;
        }


        private void Simular_Button_Click(object sender, RoutedEventArgs e)
        {
            double rendimento = saldoAtual * 0.005;
            double saldoTotal = saldoAtual + rendimento;
            MessageBox.Show($"Seu rendimento estimado é R$ {rendimento:F2}.\n" +
                            $"Seu saldo Total seria de: R$ {saldoTotal:F2}."  );
        }

        private void Confirmar_Button_Click(object sender, RoutedEventArgs e)
        {
            double rendimento = saldoAtual * 0.005;
            this.NovoSaldo = saldoAtual + rendimento;
            this.DialogResult = true;
        }

        private void Cancelar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
