﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstract;
using Domain.Entities;

namespace Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        EFDbContext _context =new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return _context.Products; }
        }
    }
}