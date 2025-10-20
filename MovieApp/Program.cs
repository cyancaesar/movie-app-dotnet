using Microsoft.EntityFrameworkCore;
using MovieApp.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MovieAppContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("MovieAppContext") 
?? throw new InvalidOperationException("Connection string 'MovieAppContext' not found.")));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=Index}/{id?}")
    .WithStaticAssets();

// Redirect to an page when the response code is 404
app.UseStatusCodePagesWithReExecute("/Movies");

app.Run();