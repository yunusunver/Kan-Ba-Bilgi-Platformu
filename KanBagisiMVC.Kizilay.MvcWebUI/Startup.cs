using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KanBagisiMVC.Kizilay.Business.Abstract;
using KanBagisiMVC.Kizilay.Business.Concrete;
using KanBagisiMVC.Kizilay.DataAccess.Abstract;
using KanBagisiMVC.Kizilay.DataAccess.Concrete.EntityFramework;
using KanBagisiMVC.Kizilay.MvcWebUI.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KanBagisiMVC.Kizilay.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBagisciService, BagisciManager>();
            services.AddScoped<IBagisciDal, EfBagisciDal>();
            services.AddScoped<IHastaService,HastaManager>();
            services.AddScoped<IHastaDal, EfHastaDal>();
            services.AddMvc();

          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);

            app.UseMvcWithDefaultRoute();
        }
    }
}
