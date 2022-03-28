using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Znaniya.Domain;
using Znaniya.Domain.Repositories.Abstract;
using Znaniya.Domain.Repositories.EntityFramework;
using Znaniya.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Configuration.Bind("Project", new Config());

//подключаем нужный функционал приложения в качестве сервисов
builder.Services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
builder.Services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
builder.Services.AddTransient<DataManager>();

//подключаем контекст БД
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString!));

var app = builder.Build();

//настраиваем identity систему
builder.Services.AddIdentity<IdentityUser, IdentityRole>(opts =>
{
    opts.User.RequireUniqueEmail = true;
    opts.Password.RequiredLength = 6;
    opts.Password.RequireNonAlphanumeric = false;
    opts.Password.RequireLowercase = false;
    opts.Password.RequireUppercase = false;
    opts.Password.RequireDigit = false;
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

//настраиваем authentication cookie
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "myCompanyAuth";
    options.Cookie.HttpOnly = true;
    options.LoginPath = "/account/login";
    options.AccessDeniedPath = "/account/accessdenied";
    options.SlidingExpiration = true;
});

//добавляем сервисы для контроллеров и представлений (MVC)
builder.Services.AddControllersWithViews();

// Configure the HTTP request pipeline.
//Подробная информация об ошибках
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
