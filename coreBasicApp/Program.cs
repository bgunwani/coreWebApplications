using System;

var builder = WebApplication.CreateBuilder(args);

// Add MVC Services to the container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// MIddleware to serve defaul files
// default files: index.html, index.htm, Default.html, default.htm
// app.UseDefaultFiles();

// Configure DefaultFiles Middleware
//var defaultFileOptions = new DefaultFilesOptions();
//defaultFileOptions.DefaultFileNames.Clear();
//defaultFileOptions.DefaultFileNames.Add("home.html");
//defaultFileOptions.DefaultFileNames.Add("dashboard.html");
//app.UseDefaultFiles(defaultFileOptions);

// Enable Routing and Use endpoints for MVc
app.UseRouting();

// Middleware to serve files and folders from wwwroot.
app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    // Default Route: {controller=Home}/{action=Index}
    _ = endpoints.MapDefaultControllerRoute();
});

app.Run();
