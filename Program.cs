using MyApp.Services;

var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

// your DI registrations
builder.Services.AddScoped<IUtilityService, UtilityService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// *** IMPORTANT: default route points to Utility/Index ***
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Utility}/{action=Index}/{id?}");

app.Run();
