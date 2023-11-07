using App_Net_Maui_Controle_EPI.Data;
using App_Net_Maui_Controle_EPI.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App_Net_Maui_Controle_EPI.Context
{
    public class UsuarioContext
    {
        
        SQLiteAsyncConnection _conexaoDB;

        public UsuarioData UsuarioDataTable { get; set; }

        public UsuarioContext()
        {
            string path = Constants.GetLocalFilePath("usuarios.db3");

            if (_conexaoDB is not null) { return; }
            _conexaoDB = new SQLiteAsyncConnection(path);


            _conexaoDB.CreateTableAsync<Usuario>();

            UsuarioDataTable = new UsuarioData(_conexaoDB);

        }
        
     

        private async Task CreatTable()
        {



            Usuario userAdmin = new Usuario();
            userAdmin.Name = "Admin";
            userAdmin.Senha = "admin123";
            userAdmin.Codigo = 123;
            userAdmin.Funcao = "admin";

            var result =  _conexaoDB.InsertAsync(userAdmin);


        }
    }

    

}