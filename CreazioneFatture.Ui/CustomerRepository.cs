using CreazioneFatture.Backend.Data;
using CreazioneFatture.Backend.MVVM.Models;
using SQLite;

namespace CreazioneFatture.Ui
{
    public class CustomerRepository
    {
        SQLiteConnection conn;
        public int result = 0;
        public string StatusMessage = string.Empty;
        public CustomerRepository()
        {
            conn = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);

            conn.CreateTable<TAB_Clienti>();

        }
        public void AddOrUpdate(TAB_Clienti _Clienti)
        {
            
            try
            {
                if (_Clienti.CL_Id != 0)
                {
                    result = conn.Update(_Clienti);
                    StatusMessage = 
                        $"{result} row(s) aggiornati";
                }
                else
                {
                    result = conn.Insert(_Clienti);
                    StatusMessage =
                        $"{result} row(s) inserite";
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"Errore: {ex.Message}"; 
            }
        }

        public List<TAB_Clienti>? GetAll()
        {
            try
            {
                return conn.Table<TAB_Clienti>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Errore: {ex.Message}";
            }
            return null;
        }
        public List<TAB_Clienti>? GetAlls()
        {
            try
            {
                return conn.Query<TAB_Clienti>("Select * From TAB_Clienti").ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Errore: {ex.Message}";
            }
            return null;
        }

        public TAB_Clienti? Get(int id)
        {
            try
            {
                return conn.Table<TAB_Clienti>()
                    .FirstOrDefault(cerca => cerca.CL_Id == id);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Errore: {ex.Message}";
            }
            return null;
        }

        public void Delete(int id_cliente)
        {
            try
            {
                var _cliente = Get(id_cliente);
                conn.Delete(_cliente);
            }
            catch (Exception ex)
            {
                StatusMessage =
                    $"Errore: {ex.Message}";
            }
        }
    }
}
