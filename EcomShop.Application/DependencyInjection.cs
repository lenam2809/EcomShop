using EcomShop.Application.Common.Interfaces;
using EcomShop.Core.Repositories.Command;
using EcomShop.Core.Repositories.Command.Base;
using EcomShop.Core.Repositories.Query;
using EcomShop.Core.Repositories.Query.Base;
using Microsoft.Extensions.DependencyInjection;

namespace EcomShop.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehaviour<,>));


            return services;
        }
    }
}
