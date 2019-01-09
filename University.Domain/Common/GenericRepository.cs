using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University.Domain
{
    public class GenericRepository<T> : IDbRepository<T> where T : class, IDbEntity
    {
        DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public System.Linq.IQueryable<T> AllItems
        {
            get => _context.Set<T>();
        }

        public bool AddItem(T item)
        {
            _context.Set<T>().Add(item);
            return SaveChanges();
        }

        public bool AddItems(IEnumerable<T> items)
        {
            _context.Set<T>().AddRange(items);
            return SaveChanges();
        }

        public bool ChangeItem(T item)
        {
            T modifired = AllItems.Single(x => x.Id == item.Id);
            modifired = item;
            return SaveChanges();
        }

        public bool DeleteItem(T item)
        {
            _context.Set<T>().Remove(item);
            return SaveChanges();
        }

        public bool DeleteItem(Guid id)
        {
            T removed = AllItems.Single(x => x.Id == id);
            _context.Set<T>().Remove(removed);
            return SaveChanges();
        }

        public T GetItem(Guid id)
        {
            return AllItems.Single(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            try
            {
                if (!_context.ChangeTracker.AutoDetectChangesEnabled)
                {
                    _context.ChangeTracker.DetectChanges();
                }
                _context.SaveChanges();
                _context.ChangeTracker.AutoDetectChangesEnabled = true;
                return true;
            }
#pragma warning disable CS0168
            catch (Exception e)
#pragma warning restore CS0168
            {
                return false;
            }
        }
    }
}
