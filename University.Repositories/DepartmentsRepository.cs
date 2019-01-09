using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface IDepartmentsRepository : IDbRepository<Department>
    {
    }
    public class DepartmentsRepository: GenericRepository<Department>, IDepartmentsRepository
    {
        public DepartmentsRepository(DbContext context) : base(context)
        {

        }
    }
}
