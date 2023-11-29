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

// Function to convert run length from minutes to "Xh Ymin" format
let convertRunLengthToHoursMinutes runLength =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

// Function to convert run length of a movie
let convertMovieRunLength movie =
    { movie with RunLength = convertRunLengthToHoursMinutes movie.RunLength }

// Given movie data
let coda = { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; TotalMovies = 9 }; IMDBRating = 8.1 }
let belfast = { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; TotalMovies = 23 }; IMDBRating = 7.3 }
let dontLookUp = { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam McKay"; TotalMovies = 27 }; IMDBRating = 7.2 }
let driveMyCar = { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; TotalMovies = 16 }; IMDBRating = 7.6 }
let dune = { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; TotalMovies = 24 }; IMDBRating = 8.1 }
let kingRichard = { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; TotalMovies = 151 }; IMDBRating = 7.5 }
let licoricePizza = { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; TotalMovies = 49 }; IMDBRating = 7.4 }
let nightmareAlley = { Name = "Nightmare Alley"; RunLength = 222; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; TotalMovies = 22 }; IMDBRating = 7.1 }

// Convert run length of each movie
let codaWithConvertedRunLength = convertMovieRunLength coda
let belfastWithConvertedRunLength = convertMovieRunLength belfast
let dontLookUpWithConvertedRunLength = convertMovieRunLength dontLookUp
let driveMyCarWithConvertedRunLength = convertMovieRunLength driveMyCar
let duneWithConvertedRunLength = convertMovieRunLength dune
let kingRichardWithConvertedRunLength = convertMovieRunLength kingRichard
let licoricePizzaWithConvertedRunLength = convertMovieRunLength licoricePizza
let nightmareAlleyWithConvertedRunLength = convertMovieRunLength nightmareAlley

// Print information about movies with converted run length
printfn "Movie: %s, Genre: %A, Director: %s, Run Length: %s, IMDB Rating: %f" codaWithConvertedRunLength.Name codaWithConvertedRunLength.Genre codaWithConvertedRunLength.Director.Name codaWithConvertedRunLength.RunLength codaWithConvertedRunLength.IMDBRating
printfn "Movie: %s, Genre: %A, Director: %s, Run Length: %s, IMDB Rating: %f" belfastWithConvertedRunLength.Name belfastWithConvertedRunLength.Genre belfastWithConvertedRunLength.Director.Name belfastWithConvertedRunLength.RunLength belfastWithConvertedRunLength.IMDBRating
printfn "Movie: %s, Genre: %A, Director: %s, Run Length: %s, IMDB Rating: %f" dontLookUpWithConvertedRunLength.Name dontLookUpWithConvertedRunLength.Genre dontLookUpWithConvertedRunLength.Director.Name dontLookUpWithConvertedRunLength.RunLength dontLookUpWithConvertedRunLength.IMDBRating
printfn "Movie: %s, Genre: %A, Director: %s, Run Length: %s, IMDB Rating: %f" driveMyCarWithConvertedRunLength.Name driveMyCarWithConvertedRunLength.Genre driveMyCarWithConvertedRunLength.Director.Name driveMyCarWithConvertedRunLength.RunLength driveMyCarWithConvertedRunLength.IMDBRating
printfn "Movie: %s, Genre: %A, Director: %s, Run Length: %s, IMDB Rating