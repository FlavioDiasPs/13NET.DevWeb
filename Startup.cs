using Aula01.Data;
using Aula01.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Aula01.Extensions;

namespace Aula01
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";

            services.AddDbContext<PerguntaContext>(o=>o.UseSqlServer(connection));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Aula 02 ######################################################
            //app.Use((context, next) =>
            //{
            //    context.Response.Headers.Add("X-Teste", "hearderteste");
            //    return next();
            //});

            //app.Use(async (context, next) =>
            //{
            //    var teste = 123;
            //    await next.Invoke();
            //    var teste2 = 1234;
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Quale mane");
            //});


            #region Aula 01 - Parte 02 
            // Aula 01 - Parte 02 ##################################################################################################################
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseStaticFiles();

            app.UseMeuLogPreza();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}"
               );
            });
            //###########################################################################################################################
            #endregion

            #region Aula 01  - Parte 01
            // Aula 01  - Parte 01 ##################################################################################################################
            // routes.MapRoute(
            //    name: "autor",
            //    template: "autor/{nome}",
            //    defaults: new { controller = "Autor", Action = "Index" }
            //);

            // routes.MapRoute(
            //    name: "autoresDoAno",
            //    template: "{ano:int}/autor",
            //    defaults: new { controller = "Autor", Action = "ListaDosAutoresDoAno" }
            //);

            // routes.MapRoute(
            //    name: "topicosDaCategoria",
            //    template: "{categoria}/{topico}",
            //    defaults: new { controller = "Topico", Action = "Index" }
            //);
            //##################################################################################################################
            #endregion


        }
    }    
}


