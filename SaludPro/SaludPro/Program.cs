using Microsoft.EntityFrameworkCore;
using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Application.Interfaces.Services;
using SaludPro.Core.Application.Services;
using SaludPro.Infrastructure.Persistence.Contexts;
using SaludPro.Infrastructure.Persistence.Repositories.Usuario;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SaludProContext>(options => options.UseSqlServer(connectionString));

//builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
//builder.Services.AddScoped<IUsuarioService, UsuariosServices>();



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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
