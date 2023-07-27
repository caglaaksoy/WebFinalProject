using DataAccessLayer.Actions;
using DataAccessLayer.Data;
using DataAccessLayer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IIcecekiService, IcecekService>();
builder.Services.AddScoped<ITatliService, TatliService>();
builder.Services.AddScoped<IKategoriService, KategoriService>();
builder.Services.AddDbContext<delalalaDBContext>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();


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

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=Index}/{id?}");

app.Run();
