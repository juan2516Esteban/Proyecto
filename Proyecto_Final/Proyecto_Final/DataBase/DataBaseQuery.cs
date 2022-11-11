using Proyecto_Final.Model;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto_Final.DataBase
{
    public class DataBaseQuery
    {
        readonly SQLiteAsyncConnection _database;

        public DataBaseQuery(string dbPaht)
        {
            _database = new SQLiteAsyncConnection(dbPaht);
            _database.CreateTableAsync<UserModel>().Wait();
        }

        #region CRUD
        public Task<int> SaveModelAsync<T>(T model, bool isInsert) where T : new()
        {

            if (isInsert != true)
            {
                return _database.UpdateAsync(model);
            }
            else
            {
                return _database.InsertAsync(model);
            }

        }

        public Task<int> DeleteModelAsync<T>(T model) where T : new()
        {
            return _database.DeleteAsync(model);
        }

        public Task<List<T>> QueryModel<T>(string query) where T : new()
        {
            return _database.QueryAsync<T>(query);
        }
        public Task<List<T>> GetTableModel<T>() where T : new()
        {
            return _database.Table<T>().ToListAsync();
        }

        #endregion
    }
}
