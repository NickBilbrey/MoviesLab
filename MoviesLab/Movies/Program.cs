using Movies;

List<Movie_Store> myMovies = new List<Movie_Store>()
{
    new Movie_Store("The Shawshank Redemption","Drama"),
    new Movie_Store("The Godfather","Drama"),
    new Movie_Store("The Dark Knight","Drama"),
    new Movie_Store("The Matrix","Sci-Fi"),
    new Movie_Store("Interstellar","Sci-Fi"),
    new Movie_Store("Back to the Future", "Sci-Fi"),
    new Movie_Store("Seven", "Mystery"),
    new Movie_Store("Memento", "Mystery"),
    new Movie_Store("Toy Story","Animation"),
    new Movie_Store("Spirited Away","Animation")
};

bool goAgain = false;



do
{
    Console.WriteLine("Here are our movie categories: \n Drama \n Sci-Fi \n Mystery \n Animation \n");

    Console.WriteLine("Please enter a category to see the movies we have: ");
    string userInput = Console.ReadLine();

    if (userInput == "Drama")
    {
        var dramaList = myMovies.Where(item => item.movieCategory.Contains("Drama"));

        foreach (var item in dramaList)
        {
            Console.WriteLine(item.movieTitle);
        }

    }
    else if (userInput == "Mystery")
    {
        var mysteryList = myMovies.Where(item => item.movieCategory.Contains("Mystery"));

        foreach (var item in mysteryList)
        {
            Console.WriteLine(item.movieTitle);
        }

    }
    else if (userInput == "Sci-Fi")
    {
        var scifiList = myMovies.Where(item => item.movieCategory.Contains("Sci-Fi"));

        foreach (var item in scifiList)
        {
            Console.WriteLine(item.movieTitle);
        }

    }
    else if (userInput == "Animation")
    {
        var animationList = myMovies.Where(item => item.movieCategory.Contains("Animation"));

        foreach (var item in animationList)
        {
            Console.WriteLine(item.movieTitle);
        }

    }







    Console.WriteLine("Would you like to see more of our movies? type \"y\" to continue or any other key to exit: ");
    string userAnswer = Console.ReadLine();

    if (userAnswer == "y")
    {
        goAgain = false;
    }
    else
    { 
        goAgain = true;
    }




} while (goAgain == false);