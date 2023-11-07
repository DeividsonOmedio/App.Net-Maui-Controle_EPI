using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Net_Maui_Controle_EPI.Context
{
    public static class ConectionDb
    {
        public static string DevolverRota(string nomeBaseDados)
        {
            string rotaBaseDados = string.Empty;

            if(DeviceInfo.Platform == DevicePlatform.Android)
            {
                rotaBaseDados = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                rotaBaseDados = Path.Combine(rotaBaseDados, nomeBaseDados);
            }
            return rotaBaseDados;
        }
    }
}
