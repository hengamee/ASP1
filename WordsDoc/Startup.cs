using System.Collections;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using WordsDoc.Models;
using WordsDoc.Services;
using WordsDoc.Models.Repositories;
using Newtonsoft.Json.Serialization;

namespace WordsDoc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WordsContext>(options =>
                                               options.UseSqlServer(Configuration.GetConnectionString("WDatabase")));
            services.AddControllers();
            

            services.AddHttpClient<WordApiService>(builder =>
            {
                builder.BaseAddress = new System.Uri("https://wordsapiv1.p.mashape.com/words/");
            });
           
                       //using Dependency Injection
            services.AddTransient<IWordsRepository, WordsRepository>();
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
              
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
