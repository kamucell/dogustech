
using Doruk.Application.DataResource;
using Doruk.Infracture.Data;
using Doruk.Infracture.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Doruk.Infracture
{
	public static class RegistrationOfInfractureService
	{
		public static IServiceCollection AddInfractureToService(this IServiceCollection services)
		{
			services.AddScoped<IDurationSource, DurationSource>();
			services.AddScoped<IWorkOrderSource, WorkOrderSource>();

			
			services.AddScoped<IWorkOrderService, WorkOrderService>();
			return services;
		}
	}
}
