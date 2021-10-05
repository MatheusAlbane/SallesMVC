using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Data;
using SalesMVC.Models;

namespace SalesMVC.Services
{
    public class SellerService
    {
        private readonly SalesMVCContext _context;

        public SellerService(SalesMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAl()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Departaments = _context.Departament.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

        //public void Delete(Seller obj)
        //{
        //    _context.Remove(obj);
        //    _context.SaveChanges();
        //}
    }
}
