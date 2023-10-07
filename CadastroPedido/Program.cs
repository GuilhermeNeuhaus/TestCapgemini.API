using CadastroPedido.Domain.Service.Implementation;
using CadastroPedido.Domain.Service.Interfaces;
using CadastroPedido.Infra.Data;
using CadastroPedido.Infra.Repository.Implementation;
using CadastroPedido.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroPedido
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<CadastroPedidoDBContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            builder.Services.AddCors(options => options.AddPolicy(name: "CadastroPedido",
                policy =>
                {
                    policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
                }));

            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<ITelefoneRepository, TelefoneRepository>();

            builder.Services.AddScoped<IUsuarioService, UsuarioService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("CadastroPedido");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}