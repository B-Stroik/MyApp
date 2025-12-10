using MyApp.Services;

var builder = WebApplication.CreateBuilder(args);

// 1) Register MVC
builder.Services.AddControllersWithViews();

// 2) Register your utility service for DI
builder.Services.AddScoped<IUtilityService, UtilityService>();

var app = builder.Build();

// 3) Typical middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Utility}/{action=Index}/{id?}");

app.Run();
