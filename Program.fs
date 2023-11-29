// MyFSharpApp.fsx

// Define the discriminated union genre
type Genre =
    | Drama
    | Comedy
    | Fantasy
    | Sport
    | Thriller

// Define the "Director" record type
type Director = {
    Name: string
    TotalMovies: int
}

// Define the "Movie" record type
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

// Create a list of movie instances
let moviesList = [
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; TotalMovies = 9 }; IMDBRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; TotalMovies = 23 }; IMDBRating = 7.3 }
    { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam McKay"; TotalMovies = 27 }; IMDBRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; TotalMovies = 16 }; IMDBRating = 7.6 }
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; TotalMovies = 24 }; IMDBRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; TotalMovies = 151 }; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; TotalMovies = 49 }; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 222; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; TotalMovies = 22 }; IMDBRating = 7.1 }
]

// Example usage: print information about each movie in the list
moviesList |> List.iter (fun movie ->
    printfn "Movie: %s, Genre: %A, Director: %s, Run Length: %d minutes, IMDB Rating: %f"
        movie.Name movie.Genre movie.Director.Name movie.RunLength movie.IMDBRating
)