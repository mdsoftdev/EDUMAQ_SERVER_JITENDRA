using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Edumaq.DataAccess.Models;
using Edumaq.Service.Interface;
using Edumaq.Service;
using Edumaq.Repository.Interfaces;
using Edumaq.Repository;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace Edumaq
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-IN");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("en-US"), new CultureInfo("en-IN") };
                options.RequestCultureProviders.Clear();
            });

            services.AddCors(options =>
            {
                options.AddPolicy(
                  "CorsPolicy",
                  builder => builder.WithOrigins("http://localhost:4200")
                  .AllowAnyMethod()
                  .AllowAnyHeader()
                  .AllowCredentials());
            });
            services.AddDbContext<EdumaqDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped(typeof(IAcademicYearService), typeof(AcademicYearService));
            services.AddScoped(typeof(IAcademicYearRepository), typeof(AcademicYearRepository));
            services.AddScoped(typeof(IItemGroupService), typeof(ItemGroupService));
            services.AddScoped(typeof(IItemGroupRepository), typeof(ItemGroupRepository));
            services.AddScoped(typeof(IItemCategoryService), typeof(ItemCategoryService));
            services.AddScoped(typeof(IItemCategoryRepository), typeof(ItemCategoryRepository));
            services.AddScoped(typeof(ISupplierTypeService), typeof(SupplierTypeService));
            services.AddScoped(typeof(ISupplierTypeRepository), typeof(SupplierTypeRepository));
            services.AddScoped(typeof(ITaxService), typeof(TaxService));
            services.AddScoped(typeof(ITaxRepository), typeof(TaxRepository));
            services.AddScoped(typeof(ISupplierService), typeof(SupplierService));
            services.AddScoped(typeof(ISupplierRepository), typeof(SupplierRepository));
            services.AddScoped(typeof(ICountryService), typeof(CountryService));
            services.AddScoped(typeof(ICountryRepository), typeof(CountryRepository));
            services.AddScoped(typeof(IStateService), typeof(StateService));
            services.AddScoped(typeof(IStateRepository), typeof(StateRepository));
            services.AddScoped(typeof(ICityService), typeof(CityService));
            services.AddScoped(typeof(ICityRepository), typeof(CityRepository));
            services.AddScoped(typeof(IItemService), typeof(ItemService));
            services.AddScoped(typeof(IItemRepository), typeof(ItemRepository));
            services.AddScoped(typeof(IUnitService), typeof(UnitService));
            services.AddScoped(typeof(IUnitRepository), typeof(UnitRepository));
            services.AddScoped(typeof(IColorService), typeof(ColorService));
            services.AddScoped(typeof(IColorRepository), typeof(ColorRepository));
            services.AddScoped(typeof(IProductBundleService), typeof(ProductBundleService));
            services.AddScoped(typeof(IProductBundleRepository), typeof(ProductBundleRepository));

            services.AddControllers().AddNewtonsoftJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot")),
                RequestPath = new PathString("/wwwroot")
            });

            app.UseRouting();
            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
