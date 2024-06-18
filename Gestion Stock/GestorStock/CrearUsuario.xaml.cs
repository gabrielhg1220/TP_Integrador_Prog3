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
using Microsoft.Data.SqlClient;

namespace GestorStock
{
    /// <summary>
    /// Lógica de interacción para CrearUsuario.xaml
    /// </summary>
    public partial class CrearUsuario : Window
    {
        private readonly UsuarioService _usuarioService;
        public CrearUsuario()
        {
            InitializeComponent();

            _usuarioService = new UsuarioService(new GestorStockContext());
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void BtnCerrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAgregarUsuario_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new GestorStockContext())
            {
                var _usuarioService = new UsuarioService(context);

                try
                {
                    // Agregar usuario
                    string nombre = txtNuevoUsuario.Text;
                    string password = txtNuevoPasswd.Password;

                    _usuarioService.Register(nombre, password);
                    MessageBox.Show("Usuario agregado exitosamente.");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al agregar usuario: " + ex.ToString());
                }
            }

                
        }
    }
}
