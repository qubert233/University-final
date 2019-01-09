using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface IStudentsRepository : IDbRepository<Student>
    {
    }
    public class StudentsRepository : GenericRepository<Student>, IStudentsRepository
    {
        public StudentsRepository(DbContext context) : base(context)
        {
        }
    }
}
