using System.Web.Optimization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:3000");
    });
});
builder.Services.AddRazorPages();

var app = builder.Build();

    static void RegisterBundles(BundleCollection bundles)
    {
        bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
            "~/Scripts/Lib/jquery/jquery-{version}.js",
            "~/Scripts/Lib/jquery/jquery.*",
            "~/Scripts/Lib/jquery/jquery-ui-{version}.js")
        );

        bundles.Add(new ScriptBundle("~/Scripts/knockout").Include(
             "~/Scripts/Lib/knockout/knockout-{version}.js",
             "~/Scripts/Lib/knockout/knockout-deferred-updates.js")
        );
    }


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseCors("CORSPolicy");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
