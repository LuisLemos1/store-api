﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAPI.Contracts
{
    public class CustomerByProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdOrder { get; set; }
    }
}
