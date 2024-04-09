using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneFatture.Backend.MVVM.Models
{
    public class TAB_MateriePrime
    {
        public int MP_Id { get; set; }
        public string? MP_Descrizione { get; set;}
        public string? MP_UnitaDiMisura { get; set;}
        public double MP_Prezzo { get; set;}

    }
}
