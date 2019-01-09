using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface ISubjectsRepository : IDbRepository<Subject>
    {
    }
    public class SubjectsRepository : GenericRepository<Subject>, ISubjectsRepository
    {
        public SubjectsRepository(DbContext context) : base(context)
        {

        }
    }
}
