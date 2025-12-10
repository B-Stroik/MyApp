using MyApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Register MVC
builder.Services.AddControllersWithViews();

// Register your utility service for DI
builder.Services.AddScoped<IUtilityService, UtilityService>();

var app = builder.Build();

// Typical middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Only needed if you actually have authorization attributes/policies
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Utility}/{action=Index}/{id?}");

app.Run();
