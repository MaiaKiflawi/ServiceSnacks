using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceModel
{
    public class ServiceSnack : IServiceSnack
    {
        public CityList GetAllCities()
        {
            CityDB db = new CityDB();
            CityList list = db.SelectAll();
            return list;
        }

        public SnackList GetAllSnacks()
        {
            SnackDB db = new SnackDB();
            SnackList list = db.SelectAll();
            return list;
        }

        public UserList GetAllUsers()
        {
            UserDB db = new UserDB();
            UserList list = db.SelectAll();
            return list;
        }

        public SnackList GetSnacksByUser(User user)
        {
            SnackDB db = new SnackDB();
            SnackList list = db.SelectByUser(user);
            return list;
        }

        public UserList GetUsersBySnack(Snack snack)
        {
            UserDB db = new UserDB();
            UserList list = db.SelectBySnack(snack);
            return list;
        }

        public User Login(User user)
        {
            UserDB db = new UserDB();
            return db.LogIn(user);
        }
    }
}
