using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Controllers;
using CarInsurance.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<InsuranceDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("InsuranceDb")));

var app = builder.Build();

// Seed database on startup
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<InsuranceDbContext>();
    context.Database.EnsureCreated();
    if (!context.Insurees.Any())
    {
        var insurees = new[]
        {
            new Insuree
            {
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "john.doe@example.com",
                DateOfBirth = DateTime.Today.AddYears(-22),
                CarYear = 2018,
                CarMake = "Porsche",
                CarModel = "911 Carrera",
                DUI = true,
                SpeedingTickets = 1,
                CoverageType = "Full"
            },
            new Insuree
            {
                FirstName = "Jane",
                LastName = "Smith",
                EmailAddress = "jane.smith@example.com",
                DateOfBirth = DateTime.Today.AddYears(-32),
                CarYear = 1998,
                CarMake = "Toyota",
                CarModel = "Corolla",
                DUI = false,
                SpeedingTickets = 0,
                CoverageType = "Liability"
            },
            new Insuree
            {
                FirstName = "David",
                LastName = "Jones",
                EmailAddress = "david.jones@example.com",
                DateOfBirth = DateTime.Today.AddYears(-17),
                CarYear = 2021,
                CarMake = "Tesla",
                CarModel = "Model 3",
                DUI = false,
                SpeedingTickets = 3,
                CoverageType = "Full"
            }
        };

        foreach (var i in insurees)
        {
            i.Quote = InsureeController.CalculateQuote(i);
        }

        context.Insurees.AddRange(insurees);
        context.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
