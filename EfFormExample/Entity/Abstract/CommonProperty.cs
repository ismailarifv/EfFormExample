﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFormExample.Entity.Abstract
{
    public abstract class CommonProperty
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsStatus { get; set; }=true;
        public bool IsDelete { get; set; }

    }
}
