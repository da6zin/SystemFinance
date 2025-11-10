using System.Windows;

namespace SystemFinance
{
    public partial class MainWindow : Window
    {
        private double saldo = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if(User_TextBox.Text == "User" && Senha_TextBox.Text == "123")
            {
                LoginWindow a1 = new LoginWindow();
                a1.Show();
                this.Close();
            }
            
        }

        private void User_TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Senha_TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
