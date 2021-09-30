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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace operadorLogicoE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario, senha;

            usuario = txtUsuario.Text.ToUpper();
            senha = txtSenha.Text;

            if (usuario=="ADMINISTRADOR" && senha == "123")
            {
                MessageBox.Show("Acesso liberado!!", "Login",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBox.Show("Acesso negado!!", "Login",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
