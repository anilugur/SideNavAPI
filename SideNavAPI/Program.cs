using Microsoft.EntityFrameworkCore;
using SideNavAPI.Data;
using SideNavAPI.Modules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NavDBContext>(options => options.UseInMemoryDatabase("NavDB"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/nav", (NavDBContext dbContext) =>
{
    //Test datasý
    dbContext.NavItemEntrySet.Add(new NavItemEntry { id = 1, displayName = "About", route = "aboutMR" });
    dbContext.NavItemEntrySet.Add(new NavItemEntry { id = 2, displayName = "Career", route = "careerMR" });
    dbContext.NavItemEntrySet.Add(new NavItemEntry { id = 3, displayName = "Thanks", route = "thanksMR" });
    dbContext.SaveChanges();

    return dbContext.NavItemEntrySet.ToArray<NavItemEntry>();
});


app.Run();
