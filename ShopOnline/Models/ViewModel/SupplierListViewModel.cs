﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Models.ViewModel
{
    public class SupplierListViewModel
    {
        public List<Supplier> lstSupplier { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
