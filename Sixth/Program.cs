using Sixth.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. -- DI container
builder.Services.AddSingleton<IRoller, SimpleDice>(); // per server
builder.Services.AddSingleton<SimpleDice, SimpleDice>(); // per server
//builder.Services.AddScoped<SimpleDice>(); // per seance
//builder.Services.AddTransient<SimpleDice>(); // per use
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
