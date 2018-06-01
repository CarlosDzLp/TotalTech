using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Entities;
using MyApp.Helper;
using MyApp.Model;
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

        public void Insertdoctor(Doctor doctor)
        {
            try
            {
                _connection.Insert(doctor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<int> Getcountdoctor()
        {
            try
            {
                var result = _connection.Table<Doctor>().Count();
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<IList<CollectionDoctor>> GetAlldoctor()
        {
            try
            {
                List<CollectionDoctor> doctor = new List<CollectionDoctor>();
                var result = _connection.Table<Doctor>().ToList();
                foreach (var item in result)
                {
                    doctor.Add(new CollectionDoctor
                    {
                        ranking = item.ranking,
                        street = item.street,
                        state = item.state,
                        city = item.city,
                        postcode = item.postcode.ToString(),
                        phone = item.phone,
                        email = item.email,
                        name = item.name,
                        image = item.image
                    });
                }
            
                return doctor;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public async Task<int> insertLogin()
        {
            try
            {
                LoginTable login = new LoginTable();
                login.Isloguin = true;
                login.Id = 1;
                var result = _connection.Insert(login);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<int> DeleteLogin()
        {
            try
            {
                return _connection.DeleteAll<LoginTable>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public int getLogin()
        {
            try
            {
                var result = _connection.Table<LoginTable>().Count();
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
