using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface ISpecialitiesRepository : IDbRepository<Speciality>
    {
    }
    public class SpecialitiesRepository : GenericRepository<Speciality>, ISpecialitiesRepository
    {
        public SpecialitiesRepository(DbContext context) : base(context)
        {
        }
    }
}
