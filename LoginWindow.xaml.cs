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

namespace SystemFinance
{
    public partial class LoginWindow : Window
    {
        private double saldo = 0.0;

        public LoginWindow()
        {
            InitializeComponent();
            AtualizarSaldo();
        }

        private void AtualizarSaldo()
        {
            Valor_Saldo1.Content = $"{saldo:F2}";
        }

        private void Sacar_Click(object sender, RoutedEventArgs e)
        {
            var sacarWindow = new SacarWindow(saldo);

            bool? resultado = sacarWindow.ShowDialog();

            if (resultado == true)
            {
                this.saldo = sacarWindow.NovoSaldo;

                AtualizarSaldo();
            }

        }

        private void Depositar_Click(object sender, RoutedEventArgs e)
        {
            var depositarWindow = new DepositarWindow(saldo);

            bool? resultado = depositarWindow.ShowDialog();

            if (resultado == true)
            {
                this.saldo = depositarWindow.NovoSaldo;
                AtualizarSaldo();
            }
        }

        private void Transferir_Click(object sender, RoutedEventArgs e)
        {
            var transferirWindow = new TransferirWindow(saldo);

            bool? resultado = transferirWindow.ShowDialog();

            if (resultado == true)
            {
                this.saldo = transferirWindow.novoSaldo;
                AtualizarSaldo();
            }
        }

        private void Poupanca_Click(object sender, RoutedEventArgs e)
        {
            var poupancaWindow = new PoupancaWindow(saldo);


            bool? resultado = poupancaWindow.ShowDialog();


            if (resultado == true)
            {
                this.saldo = poupancaWindow.NovoSaldo; 

                AtualizarSaldo();
            }

        }
    }
}
