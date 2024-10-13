using Doruk.Application.DTOs;
using Doruk.Infracture.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Doruk.Persistence.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private readonly IWorkOrderService _workOrderService;
		public ReasonAndDurationMatrix Enginee { get; set; }

		
		public IndexModel(ILogger<IndexModel> logger, IWorkOrderService workOrderService)
		{
			_logger = logger;
			_workOrderService = workOrderService;
			Enginee = _workOrderService.GetDurationAmountWithReason();

			 

		}

		public void OnGet()
		{

		}
	}
}
