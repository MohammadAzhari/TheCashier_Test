using TheCashier;
using TheCashier.Config;
using TheCashier.Repos;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<TheCashierContext>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductRepo, ProductRepo>();

// connecting to database
var db = builder.Configuration.GetSection(nameof(DB)).Get<DB>()!;
builder.Services.AddSingleton(_ => db);


var app = builder.Build();

// Configure the HTTP request pipeline.category
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
