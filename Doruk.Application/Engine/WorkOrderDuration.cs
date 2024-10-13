using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doruk.Application.DTOs;
using Doruk.Domain;

namespace Doruk.Application.Engine
{
	public  class WorkOrderDuration: IWorkOrderDuration
	{
	 

		public DTOs.ReasonAndDurationMatrix CalculateReasonAndDurationMatrix(IEnumerable<Duration> dtDuration, IEnumerable<WorkOrder> dtWorkOrder)
		{
			var mainData = new  DTOs.ReasonAndDurationMatrix();

			foreach (var durationItem in dtDuration)
				foreach (var workOrderItem in dtWorkOrder.Where(f=> !(durationItem.EndTime< f.StartTime || durationItem.StartTime> f.EndTime)).ToList())//listed only work order which are overlaps with duration
                    ProcessWorkOrderDuration(mainData, durationItem, workOrderItem);
                    
			return mainData;
		}
        private void ProcessWorkOrderDuration(ReasonAndDurationMatrix mainData, Duration durationItem, WorkOrder workOrderItem)
        {
            // Check if the work order exists, add it if not
            CheckAndAddWorkOrderItem(mainData, workOrderItem);

            // Add or update the duration for the specific reason
            AddOrUpdateDuration(mainData, durationItem, workOrderItem);
        }
        private static void CheckAndAddWorkOrderItem(ReasonAndDurationMatrix mainData, WorkOrder workOrderItem)
        {
            // Check if the work order exists in the main data, add it if not
            if (!mainData.WorkOrderDuration.ContainsKey(workOrderItem.WorkOrderId))
                mainData.WorkOrderDuration.Add(workOrderItem.WorkOrderId, new Dictionary<string, double>());
        }


        private void AddOrUpdateDuration(ReasonAndDurationMatrix mainData, Duration durationItem, WorkOrder workOrderItem)
        {
            // Add or update the duration for the specific reason
            var durationAmount = CalculateDuration(durationItem, workOrderItem);
            var eventDetail = mainData.WorkOrderDuration[workOrderItem.WorkOrderId];
            if (!eventDetail.ContainsKey(durationItem.Reason))
                eventDetail.Add(durationItem.Reason, durationAmount);
            else
                eventDetail[durationItem.Reason] += durationAmount;
        }
        //Calculates  times of duration in minutes units
        private double CalculateDuration(Duration durationItem, WorkOrder workOrderItem) => (MinDate(durationItem.EndTime, workOrderItem.EndTime) - MaxDate(durationItem.StartTime, workOrderItem.StartTime)).TotalMinutes;
        //Returns the last of the two provided DateTime values.
        private DateTime MaxDate(DateTime firstTime, DateTime secondTime) =>(firstTime > secondTime) ? firstTime : secondTime;
        //Returns the first of the two provided DateTime values.
        private DateTime MinDate(DateTime firstTime, DateTime secondTime) => (firstTime < secondTime) ? firstTime : secondTime;
    }
}
