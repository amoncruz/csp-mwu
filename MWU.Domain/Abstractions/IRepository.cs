using System.Collections.Generic;
using System.Threading.Tasks;

namespace MWU.Domain.Abstractions
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> ExecAllStoredProcedure(IEnumerable<T> ExecWithStoreProcedure);
        Task<T> ExecStoredProcedure(IEnumerable<T> ExecWithStoreProcedure);
    }
}
