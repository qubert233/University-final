using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface ITeachersRepository : IDbRepository<Teacher>
    {
    }
    public class TeachersRepository : GenericRepository<Teacher>, ITeachersRepository
    {
        public TeachersRepository(DbContext context) : base(context)
        {
        }
    }
}
