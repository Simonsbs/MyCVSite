using Microsoft.EntityFrameworkCore;
using MyCVSite.API.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MainContext>(o => {
	o.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// This code makes sure the DB is up to date every time the API starts
using (var scope = app.Services.CreateScope()) {
	var context = scope.ServiceProvider.GetRequiredService<MainContext>();
	context.Database.Migrate();
}

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
