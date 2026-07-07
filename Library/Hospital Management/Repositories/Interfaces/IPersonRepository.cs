using Hospital_Management.Models;

namespace Hospital_Management.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        public List<Person> GetAllPersons();
    }
}
