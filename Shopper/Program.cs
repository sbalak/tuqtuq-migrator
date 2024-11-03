using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shopper.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(IdentityConstants.ApplicationScheme)
    .AddCookie(IdentityConstants.ApplicationScheme)
    .AddBearerToken(IdentityConstants.BearerScheme);

builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<ShopperContext>()
    .AddApiEndpoints();

builder.Services.AddDbContext<ShopperContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ShopperContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.MapIdentityApi<User>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.Run();