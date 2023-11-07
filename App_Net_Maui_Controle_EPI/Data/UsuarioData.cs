using App_Net_Maui_Controle_EPI.Interfaces;
using App_Net_Maui_Controle_EPI.Model;
using App_Net_Maui_Controle_EPI.Pages;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Net_Maui_Controle_EPI.Data
{
    public class UsuarioData
    {
        private SQLiteAsyncConnection _conexaoDB;

        public UsuarioData(SQLiteAsyncConnection conexaoBD)
        {
            _conexaoDB = conexaoBD;
        }

        private async Task CreatAdmin()
        {



            Usuario userAdmin = new Usuario();
            userAdmin.Name = "Admin";
            userAdmin.Senha = "admin123";
            userAdmin.Codigo = 123;
            userAdmin.Funcao = "admin";

            var result = await _conexaoDB.InsertAsync(userAdmin);


        }

       

        public  Task<List<Usuario>> GetAllUsers()
        {
            var lista = _conexaoDB
                .Table<Usuario>()
                .ToListAsync();

            return lista;
        }

        public Task<Usuario> GetUser(string userName, string password) 
        {
            try
            {
                var usuario = _conexaoDB
                .Table<Usuario>()
                .Where(x => x.Name == userName)
                .FirstOrDefaultAsync();

                return usuario;
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> CreateUser(Usuario usuario)
        {
            try
            {
                return await _conexaoDB.InsertAsync(usuario);
            }
            catch
            {
                return 0;
            }
        }

        

      
    }
}
