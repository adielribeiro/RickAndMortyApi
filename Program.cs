using Microsoft.EntityFrameworkCore;
using Rm.API.Services;
using Rm.API.Context;
using Rm.API.Repositories;

internal class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

       var connection = builder.Configuration["ConexaoSqlServer:SqlServerConnectionString"];

        builder.Services.AddDbContext<AppDBContext>(config =>  
            {  
                config.UseSqlServer(connection); 
            });  

        // Add services to the container.

        builder.Services.AddControllers().AddNewtonsoftJson();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<iCharServices, CharServices>();
        builder.Services.AddScoped<ICharRepositories, CharRepositories>();

        var app = builder.Build();

       // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
         {
            app.UseSwagger();
            app.UseSwaggerUI();
         }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }

    
          private string GetDebuggerDisplay()
    {

        return ToString();

    }

}