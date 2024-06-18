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
    /// Lógica de interacción para UpdateProductWindow.xaml
    /// </summary>
    public partial class UpdateProductWindow : Window
    {
        private readonly ProductoService _productoService;
        private readonly int _productoId;

        public UpdateProductWindow(int productoId)
        {
            InitializeComponent();

            _productoService = new ProductoService(new GestorStockContext());
            _productoId = productoId;
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            var producto = _productoService.GetProductos().FirstOrDefault(p => p.ProductoId == _productoId);
            if (producto != null)
            {
                txtNombreProducto.Text = producto.Nombre;
                txtCategoriaId.Text = producto.CategoriaId.ToString();
                checkboxHabilitado.IsChecked = producto.Habilitado;
            }
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

        private void BtnActualizarProducto_Click(object sender, RoutedEventArgs e)
        {
            var nombre = txtNombreProducto.Text;
            var categoriaId = int.Parse(txtCategoriaId.Text);
            var habilitado = checkboxHabilitado.IsChecked ?? false;

            _productoService.UpdateProducto(_productoId, nombre, categoriaId, habilitado);
            this.Close();
        }
    }
}
