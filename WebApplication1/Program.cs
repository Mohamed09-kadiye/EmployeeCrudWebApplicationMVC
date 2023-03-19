using WebApplication1.Models.Interfaces;
using WebApplication1.Models.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProduct,ProductRepo>();
builder.Services.AddScoped<ICustomer, CustomerRepo>();

var app = builder.Build();

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
    name: "Horyaal",
    pattern: "{controller=Customer}/State/{action=GetAll}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=GetAll}/{id?}");

app.Run();
