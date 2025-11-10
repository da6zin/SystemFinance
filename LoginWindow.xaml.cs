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
    /// <summary>
    /// Lógica interna para LoginWindow.xaml
    /// </summary>
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
            sacarWindow.ShowDialog();
            AtualizarSaldo();
        }

        private void Depositar_Click(object sender, RoutedEventArgs e)
        {
            var depositarWindow = new DepositarWindow(saldo); // 'saldo' é o valor antigo

            // 1. ShowDialog() retorna um 'bool?' (true, false ou null)
            //    Ele será 'true' se você definiu "DialogResult = true" lá dentro.
            bool? resultado = depositarWindow.ShowDialog();

            // 2. Verifique se o usuário clicou em "Confirmar" (resultado == true)
            if (resultado == true)
            {
                // 3. Se sim, puxe o novo valor da propriedade pública da dialog
                this.saldo = depositarWindow.NovoSaldo; // ATUALIZA A VARIÁVEL DA MAINWINDOW

                // 4. AGORA sim, chame o método para atualizar a UI com o novo valor
                AtualizarSaldo();
            }
            // Se o resultado for 'false' ou 'null' (usuário cancelou),
            // o código simplesmente termina e o 'AtualizarSaldo()' não é chamado,
            // mantendo o saldo antigo.
        }

        private void Transferir_Click(object sender, RoutedEventArgs e)
        {
            var transferirWindow = new TransferirWindow(saldo);
            transferirWindow.ShowDialog();
            AtualizarSaldo();
        }

        private void Poupanca_Click(object sender, RoutedEventArgs e)
        {
            var poupancaWindow = new PoupancaWindow(saldo);
            poupancaWindow.ShowDialog();
            AtualizarSaldo();
        }
    }
}
