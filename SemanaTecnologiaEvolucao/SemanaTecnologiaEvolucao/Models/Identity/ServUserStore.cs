using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;

namespace SemanaTecnologiaEvolucao.Models.Identity
{
    public class ServUserStore : IUserPasswordStore<Usuario, int>
    {
        private readonly ServicoDbContext _dbContext;

        public ServUserStore()
        {
            _dbContext = new ServicoDbContext();
        }

        public void Dispose()
        {
        }

        public Task CreateAsync(Usuario user)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Usuario user)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(Usuario user)
        {
            throw new System.NotImplementedException();
        }

        public Task<Usuario> FindByIdAsync(int userId)
        {
            return _dbContext.Usuario.FindAsync(userId);
        }

        public Task<Usuario> FindByNameAsync(string userName)
        {
            return Task.Run(() =>
            {
                int idUsuario;
                int.TryParse(userName, out idUsuario);
                var usuario = _dbContext.Usuario.FirstOrDefault(u => u.CodigoFaculdade == idUsuario.ToString());

                return usuario;
            });
        }

        public Task SetPasswordHashAsync(Usuario user, string passwordHash)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(Usuario user)
        {
            return Task.Run(() => user.Senha);
        }

        public Task<bool> HasPasswordAsync(Usuario user)
        {
            throw new System.NotImplementedException();
        }
    }
}