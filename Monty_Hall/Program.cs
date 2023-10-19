var builder = WebApplication.CreateBuilder(args);
var Configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

string allowedOrigins = Configuration["Cors:AllowedOrigins"];
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "allowedOrigins",
        builder =>
        {
            builder.WithOrigins(allowedOrigins.Split(",")).AllowAnyHeader().AllowAnyMethod();
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("allowedOrigins");

app.Run();
