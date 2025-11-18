using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Globalization;

namespace SystemFinance
{
    public partial class DepositarWindow : Window
    {
        public double NovoSaldo { get; private set; }

        private double saldoAtual;

        public DepositarWindow(double saldoInicial)
        {
            InitializeComponent();
            saldoAtual = saldoInicial;
            this.NovoSaldo = saldoInicial; 
        }


        private void BotaoConfirmarDeposito_Click(object sender, RoutedEventArgs e)
        {
            double valorDepositado = double.Parse(txtValor.Text);
            this.NovoSaldo = saldoAtual + valorDepositado;
            this.DialogResult = true;
        }

        private void BotaoCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void txtValor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

