using Microsoft.AspNetCore.Components.Web;
using modul8_1302204035.Properties;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
       new WeatherForecast
       (
           DateTime.Now.AddDays(index),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

//Movies

var movies = new List<Movie>();
//create new movie
movies.Add(new Movie("The Shawshank Redemption", "Frank Darabont", new List<string>(){ "Tim Robbins", "Morgan Freeman", "Bob Gunton" }, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."));
movies.Add( new Movie("The Godfather", "Francis Ford Coppola", new List<string>(){"Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton "}, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."));
movies.Add(new Movie("The Dark Knight", "Christopher Nolan", new List<string>(){"Christian Bale", "Heath Ledger", "Aaron Eckhart"}, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."));


//create new api get movies
app.MapGet("/api/Movies", () =>
{
    return movies;
});

//create new api post movies
app.MapPost("/api/Movies", () =>
{
    return movies;
});


//create new api get movies id
app.MapGet("/api/Movies/{id}", () =>
{
    int id = 0;
    return movies[id];
});

//create new api delete movies id
app.MapDelete("/api/Movies/{id}", () =>
{
    int id = 1;
    movies.RemoveAt(id);
    return movies;
});


app.Run();
internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}