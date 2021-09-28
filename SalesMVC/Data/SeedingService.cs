using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Models;
using SalesMVC.Models.Enums;

namespace SalesMVC.Data
{
    public class SeedingService
    {
        private SalesMVCContext _context;

        public SeedingService(SalesMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
                //Banco de dados já foi populado ou há dados.
            }

            Departament d1 = new Departament(1,"Computers"); 
            Departament d2 = new Departament(2,"Electrones"); 
            Departament d3 = new Departament(3,"Carros"); 
            Departament d4 = new Departament(4,"Motos");

            Seller s1 = new Seller(1,"Albane","matheusalbane@gmail.com",new DateTime(1994,5,17), 1000.0,d1);
            Seller s2 = new Seller(2,"Albane","matheusalbane@gmail.com",new DateTime(1980,1,4), 2000.0,d2);
            Seller s3 = new Seller(3,"Albane","matheusalbane@gmail.com",new DateTime(1999,3,7), 3000.0,d3);
            Seller s4 = new Seller(4,"Albane","matheusalbane@gmail.com",new DateTime(1985,2,27), 4000.0,d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018,9,25), 11000.00, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2019,5,18), 11000.00, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2019,5,18), 11000.00, SaleStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2020,7,15), 11000.00, SaleStatus.Billed, s3);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2020,7,15), 11000.00, SaleStatus.Billed, s4);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018,3,12), 11000.00, SaleStatus.Billed, s4);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2018,3,12), 11000.00, SaleStatus.Billed, s1);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2018, 9, 25), 11000.00, SaleStatus.Billed, s2);

            _context.Departament.AddRange(d1,d2,d3,d4);
            _context.Seller.AddRange(s1,s2,s3,s4);
            _context.SalesRecord.AddRange(sr1,sr2,sr3,sr4,sr5,sr6,sr7,sr8);

            _context.SaveChanges();
        }
    }
}
