using DB;
using Microsoft.EntityFrameworkCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<PruebaContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("PruebaDBConexion"));
});

var app = builder.Build();

/*ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

using (var scope = app.Services.CreateScope()) {
    var dataContext = scope.ServiceProvider.GetRequiredService<PruebaContext>();
    dataContext.Database.Migrate();
}*/

    // Configure the HTTP request pipeline.

  

app.UseAuthorization();

app.MapControllers();

app.Run();
