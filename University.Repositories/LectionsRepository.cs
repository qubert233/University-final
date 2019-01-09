using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface ILectionsRepository : IDbRepository<Lection>
    {
    }
    public class LectionsRepository : GenericRepository<Lection>, ILectionsRepository
    {
        public LectionsRepository(DbContext context) : base(context)
        {
        }
    }
}
