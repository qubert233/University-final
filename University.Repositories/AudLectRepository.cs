using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface IAudLectRepository : IDbRepository<AudLect>
    {
    }
    public class AudLectRepository : GenericRepository<AudLect>, IAudLectRepository
    {
        public AudLectRepository(DbContext context) : base(context)
        {
        }
    }
}
