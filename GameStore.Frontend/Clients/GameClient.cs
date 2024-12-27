using GameStore.Frontend.Models;


namespace GameStore.Frontend.Clients;

public class GameClient
{

  private readonly List <GameSummary> games =
  [
  new(){
Id = 1,
Name = "Street Fighter 2",
Genre = "Action",
Price = 19.99M,
ReleaseDate = new DateOnly(1992, 7, 15)
},

new(){
Id = 2,
Name = "Final Fantasy 15",
Genre = "Role Playing",
Price = 59.99M,
ReleaseDate = new DateOnly(2010, 9, 30)
},

new(){
Id = 3,
Name = "Fifa 23",
Genre = "Sports",
Price = 69.99M,
ReleaseDate = new DateOnly(2022, 9, 27)
},

new()
{
Id = 4,
Name = "Cyberpunk 2077",
Genre = "Action Role-Playing",
Price = 49.99M,
ReleaseDate = new DateOnly(2020, 12, 10)
},

new()
{
Id = 5,
Name = "Minecraft",
Genre = "Sandbox",
Price = 29.99M,
ReleaseDate = new DateOnly(2011, 11, 18)
},

new()
{
Id = 6,
Name = "The Witcher 3: Wild Hunt",
Genre = "Role Playing",
Price = 39.99M,
ReleaseDate = new DateOnly(2015, 5, 19)
},

new()
{
Id = 7,
Name = "Grand Theft Auto V",
Genre = "Action-Adventure",
Price = 59.99M,
ReleaseDate = new DateOnly(2013, 9, 17)
},

new()
{
Id = 8,
Name = "Call of Duty: Modern Warfare II",
Genre = "First-Person Shooter",
Price = 69.99M,
ReleaseDate = new DateOnly(2022, 10, 28)
},

new()
{
Id = 9,
Name = "Elden Ring",
Genre = "Action Role-Playing",
Price = 59.99M,
ReleaseDate = new DateOnly(2022, 2, 25)
},

new()
{
Id = 10,
Name = "Animal Crossing: New Horizons",
Genre = "Life Simulation",
Price = 49.99M,
ReleaseDate = new DateOnly(2020, 3, 20)
},

];

  private readonly Genre[] genres = new GenresClient().GetGenres();
  public GameSummary[] GetGames() => [.. games];

  public void AddGame(GameDetails game){
    ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);

    var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));

    var gameSummary = new GameSummary
    {
      Id = games.Count + 1,
      Name = game.Name,
      Genre = genre.Name,
      Price = game.Price,
      ReleaseDate = game.ReleaseDate
    };
    games.Add(gameSummary);
  }
}
