using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneFatture.Backend.MVVM.Models
{
    public class TAB_Fattura
    {
        public int FT_Id { get; set; }
        [ForeignKey(nameof(TAB_Clienti.CL_Id))]
        public string? FT_CodCli { get; set; }
    }
}
