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

using System.Globalization; // Para usar CultureInfo

namespace SystemFinance
{
    public partial class DepositarWindow : Window
    {
        // 1. Crie uma propriedade pública para "devolver" o novo saldo
        public double NovoSaldo { get; private set; }

        private double _saldoAtual;

        public DepositarWindow(double saldoInicial)
        {
            InitializeComponent();
            _saldoAtual = saldoInicial;
            this.NovoSaldo = saldoInicial; // Garante que ela comece com o valor antigo
                                           // (Você provavelmente já exibe isso em algum lugar)
        }

        // 2. No botão de CONFIRMAR o depósito
        private void BotaoConfirmarDeposito_Click(object sender, RoutedEventArgs e)
        {
            // ... (seu código para pegar o valor do TextBox) ...
            double valorDepositado = double.Parse(txtValor.Text);

            // 3. Atualize a propriedade pública
            this.NovoSaldo = _saldoAtual + valorDepositado;

            // 4. IMPORTANTE: Sinalize que a operação foi um "sucesso"
            // Isso também fecha a janela automaticamente.
            this.DialogResult = true;
        }

        // (Opcional) No botão de CANCELAR
        private void BotaoCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Sinaliza que foi "cancelado" e fecha a janela
            this.DialogResult = false;
        }


    }
}

