using Microsoft.Extensions.DependencyInjection;
using School.BusinessLogic;
using School.BusinessLogic.Interfaces;
using School.Services;
using School.Services.Interfaces;
using System.Runtime.CompilerServices;

namespace School.DependencyInjection
{
    public static class DIAdapter
    {
        public static void AddMyServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IStudentBusinessLogic, StudentBusinessLogic>();
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}