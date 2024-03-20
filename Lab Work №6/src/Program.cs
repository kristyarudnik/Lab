using Lab4.Data;
using Lab4.Implementation;
using Lab4.Implementation.FacadeElements;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ���������� �������� � ���������.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("HotelBookingDb"));

builder.Services.AddTransient<RoomFacade>();
builder.Services.AddTransient<RoomBookingService>();
builder.Services.AddTransient<RoomRatingService>();
builder.Services.AddTransient<RoomRatingService>();

var app = builder.Build();

// ������������� ���� ������ ���������� �������
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    await Seed.SeedData(context);
}

// ��������� HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();