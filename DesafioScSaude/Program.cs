using DesafioScSaude.Models;
using DesafioScSaude.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Data Source=tcp:desafiosaude.database.windows.net,1433;Initial Catalog=DesafioScSaude_db;User Id=leinane@desafiosaude;Password=4321
//Data Source=DESKTOP-7TP6GQG\\SQLEXPRESS2024;Initial Catalog=cadastroSus;Integrated Security=True;Encrypt=False
//Server=tcp:desafiosaude.database.windows.net,1433;Initial Catalog=DesafioScSaude_db;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Authentication="Active Directory Password";
builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer("Data Source=DESKTOP-7TP6GQG\\SQLEXPRESS2024;Initial Catalog=cadastroSus;Integrated Security=True;Encrypt=False"));
builder.Services.AddScoped<IUsuarioRepository, UsuarioRopository>();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
