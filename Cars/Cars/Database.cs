using System;
using Cars.Properties;
using System.Windows.Forms.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    static class Database
    {
             static Database()
        {
            Cars = new List<Car>();
            Users = new List<User>();
            User me = new User();
            me.Username = "Admin";
            me.Password = "123";
            Users.Add(me);

            Markas = new List<Marka>();
            Markas.Add(new Marka()
            {
                Id = 1,
                Name = "BMW"
            });
            Markas.Add(new Marka()
            {
                Id = 2,
                Name = "Mercedes"
            });
            Models = new List<Model>()
            {
                 new Model()
                    {
                       Id = 1,
                       MarkaId = 1,
                       Name = "M5"
                    },
                     new Model()
                    {
                       Id = 2,
                       MarkaId = 1,
                       Name = "M3"
                    },

                      new Model()
                    {
                       Id = 3,
                       MarkaId = 2,
                       Name = "S class"
                    },
                     new Model()
                    {
                       Id = 4,
                       MarkaId = 2,
                       Name = "E class"
                    },
            };              

        }

           public static List<Car> Cars {get; set;}

        internal static string GetMarkaNameById(int markid)
        {
            Marka marka = new Marka();
            foreach(Marka item in Markas)
            {
                if(item.Id == markid)
                {
                    marka = item;
                }
            }
            return marka.Name;
        }

        public static string GetModelNameById(int modelid)
        {
            Model model = new Model();
            foreach(Model item in Models)
            {
                if(item.Id == modelid)
                {
                    model = item;
                }
            }
            return model.Name;
        }

          public static List<User> Users { get; set;}
           public static List<Marka> Markas { get; set;}
           public static List<Model> Models { get; set;}

        public static bool FindUser(User user)
        {
            bool Found = false;   
                foreach (User u in Database.Users)
             {
                if (u.Username.ToLower() == user.Username && u.Password.ToLower() == user.Password)
                {
                    Found = true;
                    break;
                }
            }
            return Found;
        }

        public static List<Model> Getmodels(int markaid)
        {
            List<Model> models = new List<Model>();
            foreach(Model item in Models)
            {
                if(item.MarkaId == markaid)
                {
                    models.Add(item);
                }
            }
            return models;
        }
    }
}
