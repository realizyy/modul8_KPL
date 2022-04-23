namespace modul8_1302204035.Properties;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public List<string> Stars { get; set; }
    public string Description { get; set; }


    public Movie(string title, string director, List<string> stars, string description)
    {
        Title = title;
        Director = director;
        Stars = stars;
        Description = description;
    }

    //create static movie list
    public static List<Movie> MovieList = new List<Movie>()
    {
        new Movie("The Shawshank Redemption", "Frank Darabont", new List<string>(){ "Tim Robbins", "Morgan Freeman", "Bob Gunton" }, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency." ),
        new Movie("The Godfather", "Francis Ford Coppola", new List<string>(){ "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton "}, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
        new Movie("The Dark Knight", "Christopher Nolan", new List<string>(){ "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"}, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
    };
}
