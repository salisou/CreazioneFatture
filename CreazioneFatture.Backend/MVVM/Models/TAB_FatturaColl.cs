using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneFatture.Backend.MVVM.Models
{
    public class TAB_FatturaColl
    {
        public int FC_Id { get; set; }
        public int FC_NumMat { get; set; }
        public int? FC_CodMP { get; set; }
    }
}
