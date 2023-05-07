using TestingApp.Models;

namespace TestingApp.Repository
{
    public interface IPlanningRepository
    {
        public void Add(Planning planning);
        public void Remove(Planning planning);
        public void Update(Planning planning);
        public void Delete(Planning planning);
        public Task<IEnumerable<Planning>> GetAll();
        public Planning GetById(int Id);
    }
}
