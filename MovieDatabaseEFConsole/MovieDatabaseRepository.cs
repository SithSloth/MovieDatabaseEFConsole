using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieDatabaseDTO;


namespace MovieRepository 
{
    public class MovieDatabaseRepository
    {
        private IConfigurationRoot _configuration;
        private DbContextOptionsBuilder<ApplicationDBContext> _optionsBuilder;

        public MovieDatabaseRepository()
        {
            BuildOptions();
        }
        private void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MovieDatabaseManager"));
        }

        public bool AddItem(Movie itemToAdd)
        {
            using (ApplicationDBContext db = new ApplicationDBContext(_optionsBuilder.Options))
            {
                Movie existingItem = db.Movies.FirstOrDefault(x => x.Title.ToLower() == itemToAdd.Title.ToLower());

                if (existingItem == null)
                {

                    db.Movies.Add(itemToAdd);
                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }




    }
}
