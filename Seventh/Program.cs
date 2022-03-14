using Microsoft.Extensions.DependencyInjection;
using Seventh.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSingleton<DiceOptions>();
//builder.Services.AddSingleton<Dice>();
//builder.Services.AddScoped<Dice>();
builder.Services.Configure<DiceOptions>(builder.Configuration.GetSection("Dice"));
builder.Services.AddTransient<Dice>();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
