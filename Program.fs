// Define the discriminated union genre
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

// Define the "Director" record type
type Director = {
    Name: string
    Movies: int
}

// Define the "Movie" discriminated union type
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

// Example usage
let christopherNolan = { Name = "Christopher Nolan"; Movies = 10 }

let inception = {
    Name = "Inception"
    RunLength = 148
    Genre = Fantasy
    Director = christopherNolan
    IMDBRating = 8.8
}

// Function to get the director's name from a movie
let getDirectorName (movie: Movie) =
    movie.Director.Name

// Example usage
let directorName = getDirectorName inception
printfn "Director: %s" directorName