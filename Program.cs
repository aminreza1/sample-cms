using AutoMapper;
using ContentManagementSystem.App;
using ContentManagementSystem.App.Mappers;
using ContentManagementSystem.Repositories;
using ContentManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configs = builder.Configuration;

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>
    ((opt) =>
    {
        opt.UseSqlServer(configs.GetConnectionString("CmsConnection"));
    });

builder.Services.AddScoped<IArticleRepo, ArticleRepo>();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new ArticleMappers());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

using (var serviceScope = app.Services.CreateScope())
{
    serviceScope.ServiceProvider.GetRequiredService<AppDbContext>().Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
