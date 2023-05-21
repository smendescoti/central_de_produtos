using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CentralDeProdutos.Services.Api.Setups
{
    /// <summary>
    /// Configuração da política de autenticação
    /// </summary>
    public class JwtSetup
    {
        public static void Configure(WebApplicationBuilder builder)
        {
             builder.Services.AddAuthentication(
                auth =>
                {
                    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }
                ).AddJwtBearer(
                bearer =>
                {
                    bearer.RequireHttpsMetadata = false;
                    bearer.SaveToken = true;
                    bearer.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.ASCII.GetBytes
                                (builder.Configuration.GetSection("JwtSettings").GetSection("SecretKey").Value)
                            ),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };
                });
        }
    }
}
