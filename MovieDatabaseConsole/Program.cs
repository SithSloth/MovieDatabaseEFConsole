using MovieDatabaseDomain;
using MovieDatabaseDTO;

MovieDatabaseInteractor _movieDatabaseInteractor = new MovieDatabaseInteractor();

BuildInitialMovieCollection();
LoadStartUpData();

void LoadStartUpData()
{
    foreach (Movie item in BuildInitialMovieCollection())
    {
        if (_movieDatabaseInteractor.AddNewItem(item) == true)
        {
            Console.WriteLine($"{item.Title} was added to the database.");
        }
        else
        {
            Console.WriteLine($"{item.Title} was NOT added to the database.");
        }
    }
}

List<Movie> BuildInitialMovieCollection()
{
    List<Movie> InitialMovies = new List<Movie>();
    InitialMovies.Add(new Movie() { Title = "The Green Mile", Genre = "Horror/Suspense" });
    InitialMovies.Add(new Movie() { Title = "Final Destination", Genre = "Horror/Suspense" });
    InitialMovies.Add(new Movie() { Title = "Friends with Benefits", Genre = "Romantic Comedy" });
    InitialMovies.Add(new Movie() { Title = "Bedazzled", Genre = "Romantic Comedy" });
    InitialMovies.Add(new Movie() { Title = "Constantine", Genre = "Superhero" });
    InitialMovies.Add(new Movie() { Title = "IT", Genre = "Horror/Suspense" });
    InitialMovies.Add(new Movie() { Title = "Children of the Corn", Genre = "Horror/Suspense" });
    InitialMovies.Add(new Movie() { Title = "Love Actually", Genre = "Romantic Comedy" });
    InitialMovies.Add(new Movie() { Title = "The Little Mermaid", Genre = "Childrens" });
    InitialMovies.Add(new Movie() { Title = "Pocahantas", Genre = "Childrens" });
    InitialMovies.Add(new Movie() { Title = "The Black Cauldron", Genre = "Childrens" });
    InitialMovies.Add(new Movie() { Title = "DreamCatcher", Genre = "Horror/Suspense" });
    InitialMovies.Add(new Movie() { Title = "The Shining", Genre = "Horror/Suspense" });
    InitialMovies.Add(new Movie() { Title = "Good Luck Chuck", Genre = "Romantic Comedy" });
    InitialMovies.Add(new Movie() { Title = "Ferngully", Genre = "Childrens" });
    return InitialMovies;
}




