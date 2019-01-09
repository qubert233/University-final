using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface IMarksRepository: IDbRepository<Mark>
    {
    }
    public class MarksRepository : GenericRepository<Mark>, IMarksRepository
    {
        public MarksRepository(DbContext context) : base(context)
        {
        }
    }
}
