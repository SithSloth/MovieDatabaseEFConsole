using MovieRepository;
using MovieDatabaseDTO;


namespace MovieDatabaseDomain
{
    public class MovieDatabaseInteractor
    {
        private MovieDatabaseRepository _repo;

        public MovieDatabaseInteractor()
        {
            _repo = new MovieDatabaseRepository();
        }

        public bool AddNewItem(Movie itemToAdd)
        {
            if (string.IsNullOrEmpty(itemToAdd.Title) || string.IsNullOrEmpty(itemToAdd.Genre))
            {
                throw new ArgumentException("Name and Description must contain valid text.");
            }
            return _repo.AddItem(itemToAdd);
        }
    }
}
