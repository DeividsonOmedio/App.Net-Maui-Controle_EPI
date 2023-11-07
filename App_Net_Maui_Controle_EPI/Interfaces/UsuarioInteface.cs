using App_Net_Maui_Controle_EPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Net_Maui_Controle_EPI.Interfaces
{
    public interface UsuarioInteface
    {
        Task IniTializeAsync();
        Task<int> CreateUser(Usuario usuario);
        Task<List<Usuario>> GetAllUsers();
        Task<Usuario> GetUser(string userName, string password);
    }
}
