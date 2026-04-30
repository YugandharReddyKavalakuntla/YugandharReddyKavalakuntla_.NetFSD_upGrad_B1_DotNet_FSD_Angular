using StudentCourseManagement.Data;
using Microsoft.EntityFrameworkCore;
using StudentCourseManagement.Models;
using StudentCourseManagement.repo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
