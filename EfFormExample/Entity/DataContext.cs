﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EfFormExample.Models;

namespace EfFormExample.Entity
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DbConnection")
        {

        }

        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }

    }
}
