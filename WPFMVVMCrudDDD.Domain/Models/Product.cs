﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFMVVMCrudDDD.Domain.Models
{
  public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
