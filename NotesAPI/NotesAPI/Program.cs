using Microsoft.EntityFrameworkCore;
using NotesAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// ���U SQLite ��Ʈw
builder.Services.AddDbContext<NotesContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("NotesDatabase")));

// ���U���
builder.Services.AddControllers();

// ���U Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// �ҥ� Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
