﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Role
    {
        public int ID { get; set; }
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }

    }
}
