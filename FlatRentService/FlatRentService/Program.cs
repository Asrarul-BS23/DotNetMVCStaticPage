using Microsoft.EntityFrameworkCore;
using FlatRentService.Data;
using FlatRentService.DependencyInject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IDemoLogic, DemoLogic>();
//builder.Services.AddScoped<DependencyInjection>();
//builder.Services.AddSingleton<DependencyInjection>();

/*
 builder.Services.AddDbContext<FlatDBContext>(options => 
    options.UseInMemoryDatabase(builder.Configuration.GetConnectionString("FlatDBContext"))
    );
*/
builder.Services.AddDbContext<FlatDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();