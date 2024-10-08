using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebApplication6.Repositories;
using WebApplication6.Services;
using WebApplication6.Services.ConsultaBL;
using WebApplication6.Services.ConsultaInvoice;
using WebApplication6.Services.ConsultaProcesso;
using WebApplication6.Services.ConsultaProdutos;
using static WebApplication6.Services.FinanceiroAPagarRequest;
using static WebApplication6.Services.FinanceiroAReceberRequest;

namespace WebApplication6
{
    public static class KEY
    {
        public static Guid Secret { get; set; }
    }

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
            services.AddControllers();
            services.AddScoped<LoginRequest>();
            services.AddScoped<ListaProcessos>();
            services.AddScoped<ProcessoEventosRequest>();
            services.AddScoped<ProcessosResumoRequest>();
            services.AddScoped<ConsultaBLRequest>();
            services.AddScoped<ConsultaBLContainersRequest>();
            services.AddScoped<ConsultaCERequest>();
            services.AddScoped<ListaProdutosRequest>();
            services.AddScoped<ConsultaProdutosRequest>();
            services.AddScoped<CookieRepository>();
            services.AddScoped<ConsultaInvoiceRequest>();
            services.AddScoped<ConsultaItensInvoiceRequest>();
            services.AddScoped<ConsultaDIRequest>();
            services.AddScoped<ConsultaNFSRequest>();
            services.AddScoped<ConsultaItensNFRequest>();
            services.AddScoped<ConsultaImpostosNFRequest>();
            services.AddScoped<ConsultaNFERequest>();
            services.AddScoped<ConsultaFinanceiroAPagarRequest>();
            services.AddScoped<ConsultaFinanceiroAReceberRequest>();
            services.AddScoped<ConsultaAvisoLancamentoRequest>();
            services.AddScoped<ConsultaTotalAbertoRequest>();
            // services.AddHttpContextAccessor();
            // services.AddCors();
            // KEY.Secret = Guid.NewGuid();
            // var secretKey = KEY.Secret;
            // var key = Encoding.ASCII.GetBytes(secretKey.ToString());
            // services.AddAuthentication(opt =>
            // {
            //     opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //     opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            // })
            // .AddJwtBearer(x =>
            // {
            //     x.RequireHttpsMetadata = false;
            //     x.SaveToken = true;
            //     x.TokenValidationParameters = new TokenValidationParameters
            //     {
            //         ValidateIssuerSigningKey = true,
            //         IssuerSigningKey = new SymmetricSecurityKey(key),
            //         ValidateIssuer = false,
            //         ValidateAudience = false
            //     };
            // });

            // ...
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

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            // Comentado
            // app.UseAuthentication();
            // app.UseAuthorization();

            // ...

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
