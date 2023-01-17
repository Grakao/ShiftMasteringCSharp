using Fiap.Web.AspNet4.Data;
using Fiap.Web.AspNet4.Repository;
using Fiap.Web.AspNet4.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Fiap.Web.AspNet4.ViewModel;
using Fiap.Web.AspNet4.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Habilitar para usar sessão.
builder.Services.AddSession();

var connectionString = builder.Configuration.GetConnectionString("databaseUrl");

// Mapeando Model e ViewModel com o AutoMapper
builder.Services.AddDbContext<DataContext>(options =>
	options.UseSqlServer(connectionString).EnableSensitiveDataLogging(true));

var mapperConfig = new AutoMapper.MapperConfiguration(c =>
{
	c.AllowNullDestinationValues = true;

	c.CreateMap<LoginViewModel, UsuarioModel>();
    c.CreateMap<UsuarioModel, LoginViewModel>();

    c.CreateMap<RepresentanteViewModel, RepresentanteModel>();
	c.CreateMap<RepresentanteModel, RepresentanteViewModel>();

	c.CreateMap<ClienteViewModel, ClienteModel>();
	c.CreateMap<ClienteModel, ClienteViewModel>();
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

// Mapeando Interfaces de repositório com suas respectivas classes de repositório.
builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IRepresentanteRepository, RepresentanteRepository>();
builder.Services.AddScoped<IGerenteRepository, GerenteRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

// Usar sessão.
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
