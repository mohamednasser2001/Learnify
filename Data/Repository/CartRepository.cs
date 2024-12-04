using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IRepository;
using Models;

namespace Data.Repository
{
    internal class CartRepository:Repository<Cart>,ICartRepository
    {
        public CartRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
