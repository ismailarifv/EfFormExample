using EfFormExample.Entity.Interfaces;
using EfFormExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFormExample.Entity
{
    public class UserCrud : ICrud<User>
    {
        DataContext db = new DataContext();
        public bool Add(User entity)
        {
            if (entity != null
                && !String.IsNullOrWhiteSpace(entity.Name)
                && !String.IsNullOrWhiteSpace(entity.Surname)
                && !String.IsNullOrWhiteSpace(entity.Email)
                && !String.IsNullOrWhiteSpace(entity.Password)
                
                )
            {
                db.User.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return db.User.Where(x=>x.IsDelete==false).ToList();
        }

        public bool Update(User entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
