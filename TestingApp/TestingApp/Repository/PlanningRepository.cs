using Microsoft.EntityFrameworkCore;
using TestingApp.Data;
using TestingApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingApp.Repository
    
{

    [Table("Planning")]
    public class PlanningRepository: IPlanningRepository
    {
        protected readonly TestingAppContext _context;

        public PlanningRepository (TestingAppContext context)
        {
            _context = context;
        }

        public void Add(Planning planning)
        {
            throw new NotImplementedException();
        }

        public void Delete(Planning planning)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Planning>> GetAll()
        {
            return await _context.Plannings.ToListAsync();
            //return await _context.Plannings
            //    .Include(planning => planning.Employee)
            //    .Include(planning => planning.Project)
            //    .ToListAsync();
        }

        public Planning GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Planning planning)
        {
            throw new NotImplementedException();
        }

        public void Update(Planning planning)
        {
            throw new NotImplementedException();
        }
    }
    
}
