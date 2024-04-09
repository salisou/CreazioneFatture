namespace CreazioneFatture.Backend.MVVM.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class MateriePrime
    {
        [Key]
        public int MP_Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string MP_Descrizione { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string MP_UnitaDiMisura { get; set; }

        public double MP_Prezzo { get; set; }

        // Aggiungere altre proprietà se necessario
    }

    public class Utente
    {
        [Key]
        public int UT_Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string UT_Nome { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string UT_Cognome { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string UT_PIva { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string UT_Cell1 { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string UT_Cell2 { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string UT_Mail1 { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string UT_Mail2 { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string UT_Pec { get; set; }

        // Aggiungere altre proprietà se necessario
    }

    public class Cliente
    {
        [Key]
        public int CL_Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string CL_Nome { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string CL_Cognome { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string CL_PIva { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string CL_Cell1 { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string CL_Cell2 { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string CL_Mail1 { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string CL_Mail2 { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string CL_Pec { get; set; }

        // Aggiungere altre proprietà se necessario
    }

    public class Fattura
    {
        [Key]
        public int FT_Id { get; set; }

        public int? FT_CodCli { get; set; } // Chiave esterna che può essere nulla

        // Aggiungere altre proprietà se necessario
    }

    public class FatturaColl
    {
        [Key]
        public int FC_Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FC_NumMat { get; set; }

        [ForeignKey("Fattura")]
        public int FT_Id { get; set; }

        [ForeignKey("MateriePrime")]
        public int FC_CodMP { get; set; }

        // Aggiungere altre proprietà se necessario
    }
}
