using Domain.Entities;
using University.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public interface IGroupsRepository : IDbRepository<Group>
    {
    }
    public class GroupsRepository : GenericRepository<Group>, IGroupsRepository
    {
        public GroupsRepository(DbContext context) : base(context)
        {
        }
    }
}
