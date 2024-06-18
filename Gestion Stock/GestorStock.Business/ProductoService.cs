using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorStock.DataEF;
using GestorStock.Entities;

namespace GestorStock.Business
{
    public class ProductoService
    {
        private readonly GestorStockContext _context;

        public ProductoService(GestorStockContext context)
        {
            _context = context;
        }

        public void AddProducto(string nombre, int categoriaId)
        {
            if (_context.Producto.Any(p => p.Nombre == nombre))
            {
                throw new InvalidOperationException("El producto con el mismo nombre ya existe.");
            }

            var producto = new Producto
            {
                Nombre = nombre,
                CategoriaId = categoriaId,
                Habilitado = true
            };
            _context.Producto.Add(producto);
            _context.SaveChanges();
        }

        public void UpdateProducto(int id, string nombre, int categoriaId, bool habilitado)
        {
            var producto = _context.Producto.Find(id);
            if (producto != null)
            {
                producto.Nombre = nombre;
                producto.CategoriaId = categoriaId;
                producto.Habilitado = habilitado;
                _context.SaveChanges();
            }
        }

        public void DeleteProducto(int id)
        {
            var producto = _context.Producto.Find(id);
            if (producto != null)
            {
                _context.Producto.Remove(producto);
                _context.SaveChanges();
            }
        }

        public List<Producto> GetProductos()
        {
            return _context.Producto.ToList();
        }
    }
}
