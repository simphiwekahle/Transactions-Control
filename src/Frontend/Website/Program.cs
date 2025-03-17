using Website.Configurations;
using Website.Domains.Persons;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var db = builder.Configuration.GetConnectionString("TransactionsDB")
	?? throw new InvalidOperationException("ConnectionString:TransactionsDB is missing in configutations");

builder.Services.AddPersonsServices();

builder.Services.Configure<ConnectionStringOptions>(
	builder.Configuration.GetSection("ConnectionStrings"));

builder.Services.Configure<StoredProcedureOptions>(
	builder.Configuration.GetSection("StoredProcedures"));

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
