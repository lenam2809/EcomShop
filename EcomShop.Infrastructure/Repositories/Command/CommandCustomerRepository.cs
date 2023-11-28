using EcomShop.Core.Entities;
using EcomShop.Core.Repositories.Command;
using EcomShop.Infrastructure.Data;
using EcomShop.Infrastructure.Repositories.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomShop.Infrastructure.Repositories.Command
{
    public class CustomerCommandRepository : CommandRepository<Customer>, ICustomerCommandRepository
    {
        public CustomerCommandRepository(EcomShopContext context) : base(context)
        {

        }
    }
}
