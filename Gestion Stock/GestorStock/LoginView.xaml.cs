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
using GestorStock.Business;
using GestorStock.DataEF;

namespace GestorStock
{
    /// <summary>
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        private readonly UsuarioService _usuarioService;
        public LoginView()
        {
            InitializeComponent();

            _usuarioService = new UsuarioService(new GestorStockContext());
        }

        private void WinLoginView_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var usuario = _usuarioService.Authenticate(txtUsuario.Text, txtPasswd.Password);

            if (usuario != null)
            {
                MessageBox.Show("Inicio de sesión exitoso");

                var productWindow = new ProductWindow();
                productWindow.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario o password es incorrecto.");
            }
        }

        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            var crearUsuario = new CrearUsuario();
            crearUsuario.ShowDialog();
        }
    }
}
