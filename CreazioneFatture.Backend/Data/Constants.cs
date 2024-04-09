using Microsoft.Maui.Storage;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneFatture.Backend.Data
{
    
    public static class Constants
    {
        private const string DBFileName = "Fatturazione.db3";

        public const SQLiteOpenFlags Flags =
               SQLiteOpenFlags.ReadWrite |
               SQLiteOpenFlags.Create |
               SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                return Path
                     .Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }

    }
}
