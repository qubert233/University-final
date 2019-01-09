using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface IAudiencesRepository : IDbRepository<Audience>
    {
    }
    public class AudiencesRepository : GenericRepository<Audience>, IAudiencesRepository
    {
        public AudiencesRepository(DbContext context) : base(context)
        {
        }
    }
}
