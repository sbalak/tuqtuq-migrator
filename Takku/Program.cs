using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Takku.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
                .AddJwtBearer(x =>
                {
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ForTheLoveOfGodStoreAndLoadThisSecurely")),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ClockSkew = TimeSpan.Zero
                    };
                });

builder.Services.AddDbContext<TakkuContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TakkuContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.MapIdentityApi<User>();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.Run();