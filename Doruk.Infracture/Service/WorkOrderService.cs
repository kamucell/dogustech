using Doruk.Application.DataResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doruk.Application.DTOs;
using Doruk.Domain;
using Doruk.Infracture.Data;

namespace Doruk.Infracture.Service
{
	public class WorkOrderService : IWorkOrderService
	{
		private readonly IDurationSource _durationSource;
		private readonly IWorkOrderSource _workOrder;
        public WorkOrderService()
        {
            
        }
        public WorkOrderService(IDurationSource durationSource,IWorkOrderSource workOrder)
		{
			_durationSource = durationSource;
			_workOrder = workOrder;
		}
        public ReasonAndDurationMatrix GetDurationAmountWithReason()
        {
	        var dtDuration = _durationSource.GetDurationByDate(DateTime.Now);
	        var dtWorkOrder = _workOrder.GetWorkOrderByTime(DateTime.Now);

			
			var durations = (new Doruk.Application.Engine.WorkOrderDuration()).CalculateReasonAndDurationMatrix(dtDuration,dtWorkOrder);

			durations.Reason = dtDuration.DistinctBy(f => f.Reason)
										 .Select(f => f.Reason)
										 .OrderBy(f => f)
										 .ToList();

			return durations;
		}
	}
}
