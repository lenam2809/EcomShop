using EcomShop.Core.Repositories.Query.Base;
using EcomShop.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomShop.Infrastructure.Repositories.Query.Base
{
    public class QueryRepository<T> :DbConnector, IQueryRepository<T> where T : class
    {
        public QueryRepository(IConfiguration configuration) : base(configuration) 
        {

        }
    }
}
