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

// Create director instances
let sianHeder = { Name = "Sian Heder"; TotalMovies = 9 }
let kennethBranagh = { Name = "Kenneth Branagh"; TotalMovies = 23 }
let adamMcKay = { Name = "Adam McKay"; TotalMovies = 27 }
let ryusukeHamaguchi = { Name = "Ryusuke Hamaguchi"; TotalMovies = 16 }
let denisVilleneuve = { Name = "Denis Villeneuve"; TotalMovies = 24 }
let reinaldoMarcusGreen = { Name = "Reinaldo Marcus Green"; TotalMovies = 151 }
let paulThomasAnderson = { Name = "Paul Thomas Anderson"; TotalMovies = 49 }
let guillermoDelToro = { Name = "Guillermo Del Toro"; TotalMovies = 22 }

// Create movie instances
let coda = { Name = "CODA"; RunLength = 111; Genre = Drama; Director = sianHeder; IMDBRating = 8.1 }
let belfast = { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = kennethBranagh; IMDBRating = 7.3 }
let dontLookUp = { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = adamMcKay; IMDBRating = 7.2 }
let driveMyCar = { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = ryusukeHamaguchi; IMDBRating = 7.6 }
let dune = { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = denisVilleneuve; IMDBRating = 8.1 }
let kingRichard = { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = reinaldoMarcusGreen; IMDBRating = 7.5 }
let licoricePizza = { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = paulThomasAnderson; IMDBRating = 7.4 }
let nightmareAlley = { Name = "Nightmare Alley"; RunLength = 222; Genre = Thriller; Director = guillermoDelToro; IMDBRating = 7.1 }

// Print information about movie instances
printfn "Movie: %s, Genre: %A, Director: %s, Run Length: %d minutes, IMDB Rating: %f"
    coda.Name coda.Genre coda.Director.Name coda.RunLength coda.IMDBRating

printfn "Movie: %s, Genre: %A, Director: %s, Run Length: %d minutes, IMDB Rating: %f"
    belfast.Name belfast.Genre belfast.Director.Name belfast.RunLength belfast.IMDBRating