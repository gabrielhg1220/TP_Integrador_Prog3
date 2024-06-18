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
using GestorStock.Entities;

namespace GestorStock
{
    /// <summary>
    /// Lógica de interacción para ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private readonly ProductoService _productoService;
        public ProductWindow()
        {
            InitializeComponent();

            _productoService = new ProductoService(new GestorStockContext());
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridProductos.ItemsSource = _productoService.GetProductos();
        }

        private void WinProductWindow_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void BtnCerrarWinProductos_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            var addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();
        }

        private void BtnEliminarProducto_Click(object sender, RoutedEventArgs e)
        {
            var deleteProductWindow = new DeleteProductWindow();
            deleteProductWindow.ShowDialog();
        }

        private void BtnActualizarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridProductos.SelectedItem is Producto selectedProduct)
            {
                var updateProductWindow = new UpdateProductWindow(selectedProduct.ProductoId);
                updateProductWindow.ShowDialog();
                LoadProducts();
            }
        }
    }
}
