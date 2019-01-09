using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface IPhonesRepository : IDbRepository<Phone>
    {
    }
    public class PhonesRepository : GenericRepository<Phone>, IPhonesRepository
    {
        public PhonesRepository(DbContext context) : base(context)
        {
        }
    }
}
