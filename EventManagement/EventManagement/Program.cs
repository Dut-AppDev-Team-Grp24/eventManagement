using System.Net;
using System.Text;
using EventManagement.Models;
using EventManagement.Helper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();


// In ConfigureServices method of Startup.cs

string Token = "verversecretToken:)";
var key = Encoding.ASCII.GetBytes(Token);

builder.Services.AddSingleton<IHttpContextAccessor,
HttpContextAccessor>();

builder.Services.AddAuthentication(auth =>
{
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})

.AddJwtBearer(token =>
{
     token.RequireHttpsMetadata = false;
     token.SaveToken = true;
     token.TokenValidationParameters = new TokenValidationParameters
     {
         ValidateIssuerSigningKey = true,
         IssuerSigningKey = new SymmetricSecurityKey(key),
         ValidateIssuer = true,
         ValidIssuer = "www.example.com",
         ValidateAudience = true,
         ValidAudience = "www.example.com",
         RequireExpirationTime = true,
         ValidateLifetime = true,
         ClockSkew = TimeSpan.Zero
     };
});

builder.Services.AddSingleton<JwtHelper>();

builder.Services.AddScoped<AzureBlobRepository>(sp => {
    var a = new AzureBlobRepository(
        "DefaultEndpointsProtocol=https;AccountName=grp24apda;AccountKey=Ii7o8VXeVrJaCuYnFmwRYAjfnJ9qKYqC6UCXdESd6lJCdytBTEhDffwM2WhB+91r0kkYEHtZZwrh+AStX5QZig==;EndpointSuffix=core.windows.net",
        "images"
    );
    return a;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCookiePolicy();
app.Use(async (context, next) =>
{
    var jqtToken = context.Request.Cookies["jwt-token"];
    if (!string.IsNullOrEmpty(jqtToken))
    {
        context.Request.Headers.Add($"Authorization", $"Bearer {jqtToken}");
    }
    await next();
});

app.UseAuthorization();

app.UseAuthentication();
app.UseAuthorization();
app.UseDeveloperExceptionPage();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}");

app.Run();
