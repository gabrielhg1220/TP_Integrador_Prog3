using System.Linq;
using GestorStock.DataEF;
using GestorStock.Entities;
using GestorStock.Security;

namespace GestorStock.Business
{
    public class UsuarioService
    {
        private readonly GestorStockContext _context;

        public UsuarioService(GestorStockContext context)
        {
            _context = context;
        }

        public void Register(string nombre, string password)
        {
            byte[] passwordHash, passwordSalt;
            SecurityHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            var usuario = new Usuario
            {
                Nombre = nombre,
                Hash = passwordHash,
                Salt = passwordSalt
            };

            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario Authenticate(string nombre, string password)
        {
            var usuario = _context.Usuario.SingleOrDefault(x => x.Nombre == nombre);

            if (usuario == null)
                return null;

            if (!SecurityHelper.VerifyPasswordHash(password, usuario.Hash, usuario.Salt))
                return null;

            return usuario;
        }
    }
}
