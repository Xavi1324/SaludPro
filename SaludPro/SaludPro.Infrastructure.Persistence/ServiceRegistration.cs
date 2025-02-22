using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Infrastructure.Persistence.Contexts;
using SaludPro.Infrastructure.Persistence.Repositories;
using SaludPro.Infrastructure.Persistence.Repositories.Cita;
using SaludPro.Infrastructure.Persistence.Repositories.Consultorio;
using SaludPro.Infrastructure.Persistence.Repositories.Laboratorio;
using SaludPro.Infrastructure.Persistence.Repositories.Medico;
using SaludPro.Infrastructure.Persistence.Repositories.Paciente;
using SaludPro.Infrastructure.Persistence.Repositories.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            if(configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<SaludProContext>(options =>
                    options.UseInMemoryDatabase("SaludProDb"));
            }
            else
            {
                services.AddDbContext<SaludProContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    m=> m.MigrationsAssembly(typeof(SaludProContext).Assembly.FullName)));
            }


            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepository<>));
            services.AddTransient<ICitaRepository, CitaRepository>();
            services.AddTransient<IConsultorioRepository, ConsultorioRepository>();
            services.AddTransient<IMedicoRepository, MedicoRepository>();
            services.AddTransient<IPacienteRepository, PacienteRepository>();
            services.AddTransient<IPruebasLabRepository, PruebasLabRepository>();
            services.AddTransient<IResultadosLabRepository, ResultadosLabRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();


        }
    }
}
