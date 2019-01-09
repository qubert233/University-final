using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface ITeachSubjRepository : IDbRepository<TeachSubj>
    {
    }
    public class TeachSubjRepository : GenericRepository<TeachSubj>, ITeachSubjRepository
    {
        public TeachSubjRepository(DbContext context) : base(context)
        {
        }
    }
}
