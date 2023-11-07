using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Net_Maui_Controle_EPI.Model
{
    [Table("emprestimos")]
    public class Emprestimo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("epi")]
        public Epi EpiId { get; set; }
        [ForeignKey("funcionario")]
        public Funcionario FuncionarioId { get; set; }
        public string DataPrevisaoEmprestimo { get; set; }
        public string DataEmpretimo { get; set; }
        public string DataPrevisaoDevolucao { get; set; }


    }
}
