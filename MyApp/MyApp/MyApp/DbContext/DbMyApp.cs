using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyApp.Entities;
using MyApp.Helper;
using SQLite;
using Xamarin.Forms;

namespace MyApp.DbContext
{
    public class DbMyApp
    {
        private readonly SQLiteConnection _connection;

        public DbMyApp()
        {
            try
            {
                var path = DependencyService.Get<IGetPath>().getPath();
                _connection = new SQLiteConnection(path,true);
                _connection.CreateTable<LoginTable>();
                _connection.CreateTable<Doctor>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<int> insertLogin()
        {
            LoginTable login = new LoginTable();
            login.Isloguin = true;
            var result = _connection.Insert(login);
            return result;
        }

        public async Task<int> DeleteLogin()
        {
            LoginTable login = new LoginTable();
            login.Isloguin = true;
            return _connection.Delete(login);
        }
        public async Task<int> getLogin()
        {
            return _connection.Table<LoginTable>().Count();
        }
    }
}
