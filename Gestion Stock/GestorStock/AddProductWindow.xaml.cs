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
    /// Lógica de interacción para AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        private readonly ProductoService _productoService;
        public AddProductWindow()
        {
            InitializeComponent();

            _productoService = new ProductoService(new GestorStockContext());
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            var nombre = txtProducto.Text;
            var categoriaId = int.Parse(txtCategoriaId.Text);

            _productoService.AddProducto(nombre, categoriaId);
            this.Close();
        }
    }
}
