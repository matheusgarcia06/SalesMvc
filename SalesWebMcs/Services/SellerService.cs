using SalesWebMcs.Data;
using SalesWebMcs.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMcs.Services
{
    public class SellerService
    {
        private readonly SalesWebMcsContext _context;

        public SellerService(SalesWebMcsContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
