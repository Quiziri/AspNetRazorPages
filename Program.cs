using AspNetRazorPages.data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<MoviesContext>(options => options.UseInMemoryDatabase("MyFirstApp"));

var app = builder.Build();

app.UseHttpsRedirection();

app.UseRouting();
app.MapRazorPages();

app.Run();
