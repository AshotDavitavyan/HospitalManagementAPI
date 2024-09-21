using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

void ConfigureServices(IServiceCollection services)
{
	services.AddScoped<IPatientRepository, PatientRepository>();
	services.AddScoped<IDoctorRepository, DoctorRepository>();
	services.AddScoped<IRegionRepository, RegionRepository>();
	services.AddScoped<ISpecializationRepository, SpecializationRepository>();
	services.AddScoped<ICabinetRepository, CabinetRepository>();

	services.AddScoped<IPatientService, PatientService>();
	services.AddScoped<IDoctorService, DoctorService>();

//	services.AddScoped<HospitalDbContext>(options => options.UseSqlServer("Server=localhost;Database=HospitalManagement;Trusted_Connection=True;")); //////
	services.AddControllers();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
	"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
	{
		var forecast = Enumerable.Range(1, 5).Select(index =>
				new WeatherForecast
				(
					DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
					Random.Shared.Next(-20, 55),
					summaries[Random.Shared.Next(summaries.Length)]
				))
			.ToArray();
		return forecast;
	})
	.WithName("GetWeatherForecast")
	.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
	public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}