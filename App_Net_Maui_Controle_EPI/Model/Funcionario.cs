﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Net_Maui_Controle_EPI.Model
{
    [Table("funcionarios")]
    public class Funcionario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
    }
}
