using tp9;

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

var Mahasiswa = new[]
{
   "Reyhan", "ui", "kutur", "luru"
};
var nim = new[]
{
     1302210110, 1302210198, 1302219187, 1302209876
};

app.MapGet("/Mahasiswa_1302210110", () =>
{
    var Mahasiwa = new Mahasiswa_1302210110();
    string getmahasiswa(int i, int j)
    {
        while (i < Mahasiswa.Length)
        {
            while (j < nim.Length)
            {
                return Mahasiswa[j];
            }
        }
        return null;
    }
})
.WithName("Mahasiswa");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

