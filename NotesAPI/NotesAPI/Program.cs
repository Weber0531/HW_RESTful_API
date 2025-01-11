using Microsoft.EntityFrameworkCore;
using NotesAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// 註冊 SQLite 資料庫
builder.Services.AddDbContext<NotesContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("NotesDatabase")));

// 註冊控制器
builder.Services.AddControllers();

// 註冊 Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 啟用 Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
