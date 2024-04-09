using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneFatture.Backend.MVVM.Models
{
    public class TAB_Utente
    {
        public int UT_id { get; set; }
        public string? UT_Nome { get; set; }
        public string? UT_Cognome { get; set; }
        public string? UT_PIva { get; set; }
        public int UT_Cell1 { get; set; }
        public int UT_Cell2 { get; set; }
        public string? UT_Mail1 { get; set; }
        public string? UT_Mail2 { get; set; }
        public string? UT_Pec { get; set; }
    }
}
