using exam_sem3_mvc.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("WEB");
builder.Services.AddDbContext<MyDbContext>(option =>
{
	option.UseSqlServer(connectionString);
});

// connect db

/*var connectionString = builder.Configuration.GetConnectionString("WEB");
builder.Services.AddDbContext<exam_sem3_mvc.Entities.DataContext>(
		options => options.UseSqlServer(connectionString)
	);*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
