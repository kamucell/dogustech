using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doruk.Application.DataResource;
using Doruk.Domain;

namespace Doruk.Infracture.Data
{
	public  class WorkOrderSource : IWorkOrderSource
	{
		public List<WorkOrder> GetWorkOrderByTime(DateTime startDate)
		{
			return new List<WorkOrder>
			{
				new WorkOrder ( WorkOrderId : "1001", StartTime : DateTime.Parse("2017-01-01 08:00:00"), EndTime : DateTime.Parse("2017-01-01 16:00:00") ),
				new WorkOrder ( WorkOrderId : "1002", StartTime : DateTime.Parse("2017-01-01 16:00:00"), EndTime : DateTime.Parse("2017-01-02 00:00:00") ),
				new WorkOrder ( WorkOrderId : "1003", StartTime : DateTime.Parse("2017-01-02 00:00:00"), EndTime : DateTime.Parse("2017-01-02 08:00:00") ),
				new WorkOrder ( WorkOrderId : "1004", StartTime : DateTime.Parse("2017-01-02 08:00:00"), EndTime : DateTime.Parse("2017-01-02 16:00:00") ),
				new WorkOrder ( WorkOrderId : "1005", StartTime : DateTime.Parse("2017-01-02 16:00:00"), EndTime : DateTime.Parse("2017-01-03 00:00:00") ),
				new WorkOrder ( WorkOrderId : "1006", StartTime : DateTime.Parse("2017-01-03 00:00:00"), EndTime : DateTime.Parse("2017-01-03 08:00:00") ),
				new WorkOrder ( WorkOrderId : "1007", StartTime : DateTime.Parse("2017-01-03 08:00:00"), EndTime : DateTime.Parse("2017-01-03 16:00:00") ),
				new WorkOrder ( WorkOrderId : "1008", StartTime : DateTime.Parse("2017-01-03 16:00:00"), EndTime : DateTime.Parse("2017-01-04 00:00:00") ),
				new WorkOrder ( WorkOrderId : "1009", StartTime : DateTime.Parse("2017-01-04 00:00:00"), EndTime : DateTime.Parse("2017-01-04 08:00:00") )
			}.OrderBy(f=> f.StartTime).ThenBy(f=>f.EndTime).ToList();
		}


		 
	}
}
