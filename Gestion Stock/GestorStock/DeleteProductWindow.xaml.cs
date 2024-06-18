using GestorStock.Business;
using GestorStock.DataEF;
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

namespace GestorStock
{
    /// <summary>
    /// Lógica de interacción para DeleteProductWindow.xaml
    /// </summary>
    public partial class DeleteProductWindow : Window
    {
        private readonly ProductoService _productoService;
        public DeleteProductWindow()
        {
            InitializeComponent();

            _productoService = new ProductoService(new GestorStockContext());
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductComboBox.ItemsSource = _productoService.GetProductos();
            ProductComboBox.DisplayMemberPath = "Nombre";
            ProductComboBox.SelectedValuePath = "ProductoId";
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

        private void BtnCerrar_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (ProductComboBox.SelectedValue != null)
            {
                int productId = (int)ProductComboBox.SelectedValue;
                _productoService.DeleteProducto(productId);
                MessageBox.Show("Producto eliminado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto.");
            }
        }
    }
}
