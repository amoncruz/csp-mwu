using MWU.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MWU.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task<IEnumerable<T>> ExecAllStoredProcedure(IEnumerable<T> ExecWithStoreProcedure)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecStoredProcedure(IEnumerable<T> ExecWithStoreProcedure)
        {
            throw new NotImplementedException();
        }
    }
}
