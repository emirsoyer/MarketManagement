using InMemoryStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCase;
using UseCase.Interfaces;
using WebApp.Data;

namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();


            //Dependency Injection for Category Classes
            services.AddTransient<IViewCategory, ViewCategory>();
            services.AddTransient<IAddCategory, AddCategory>();
            services.AddTransient<IEditCategory, EditCategory>();
            services.AddTransient<IGetCategoryById, GetCategoryById>();
            services.AddTransient<IDeleteCategory, DeleteCategory>();

            //Dependency Injection for Product Classes
            services.AddTransient<IViewProducts, ViewProduct>();
            services.AddTransient<IAddProduct, AddProduct>();
            services.AddTransient<IEditProduct, EditProduct>();
            services.AddTransient<IGetProductById, GetProductById>();
            services.AddTransient<IDeleteProduct, DeleteProduct>();
            services.AddTransient<IViewProductByCategoryId, ViewProductByCategoryId>();
            services.AddTransient<ISellProduct, SellProduct>();
            services.AddTransient<ILogTransaction, LogTransaction>();
            services.AddTransient<IGetTransaction, GetTransaction>();
            services.AddTransient<IGetTransactionList, GetTransactionList>();

            //Dependency Injection for In-Memory Storage
            services.AddScoped<ICategoryRepo, CategoryInMemoryRepo>();
            services.AddScoped<IProductRepo, ProductInMemoryRepo>();
            services.AddScoped<ITransactionRepo, TransactionInMemoryRepo>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
