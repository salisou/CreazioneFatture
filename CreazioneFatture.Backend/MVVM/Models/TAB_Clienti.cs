using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneFatture.Backend.MVVM.Models
{
    public class TAB_Clienti
    {
		[PrimaryKey, AutoIncrement, NotNull]
        public int CL_Id { get; set; }
		
		public string? CL_Nome { get; set; }
		public string? CL_Cognome { get; set; }
		public long? CL_PIva { get; set; }
		public string? CL_Cell1 {  get; set; }
		public string? CL_Cell2 {  get; set; }
		public string? CL_Mail1 {  get; set; }
		public string? CL_Mail2 {  get; set; }
		public string? CL_Pec {  get; set; }
    }
}
