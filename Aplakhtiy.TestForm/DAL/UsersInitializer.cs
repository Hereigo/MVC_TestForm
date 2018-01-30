using Aplakhtiy.TestForm.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Aplakhtiy.TestForm.DAL
{
    public class UsersInitializer : DropCreateDatabaseIfModelChanges<UsersContext>
    {
        protected override void Seed(UsersContext context)
        {
            var users = new List<User>
            {
                new User { Surname="Шевченко", Name="Тарас", Patronymic="Григорович", PhoneNumber="671234576" },
                new User { Surname="Косач", Name="Лариса", Patronymic="Петрівна", PhoneNumber="501234567" },
                new User { Surname="Сковорода", Name="Григорій", Patronymic="Савич", PhoneNumber="631234567" },
                new User { Surname="Хмельницький", Name="Богдан", Patronymic="Михайлович", PhoneNumber="990123456"}
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}