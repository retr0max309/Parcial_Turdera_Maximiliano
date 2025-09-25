using Microsoft.EntityFrameworkCore;
using PrimerParcial.Data; 

var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

// EF Core: usa la MISMA llave que en appsettings.json: "Default_Connection"
builder.Services.AddDbContext<RecetasDBContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Default_Connection"),
        sql => sql.EnableRetryOnFailure() // opcional: reintentos ante fallos transitorios
    )
);

var app = builder.Build();

// Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // útil en desarrollo
}
else
{
    app.UseExceptionHandler("/Home/Error");
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
