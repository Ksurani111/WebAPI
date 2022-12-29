using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data.EF.Context;
using WebAPI.Data.EF.Interface;
using WebAPI.Data.EF.Repository;
using WebAPI.Service.AutoMapper;
using WebAPI.Service.CompanyDetailsService;
using WebAPI.Service.UserDetails;
using WebAPI.Service.UserDetailsService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Db_Context>(options =>
         options.UseSqlServer("data source=LAPTOP-HDDS2EQ6;initial catalog=model;User ID=home; Password = Home123?; TrustServerCertificate=True"));
builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<ICompanyService, CompanyService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();


builder.Services.AddSingleton(mapper);

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
