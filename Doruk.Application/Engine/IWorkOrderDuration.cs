using Doruk.Domain;

namespace Doruk.Application.Engine;

public interface IWorkOrderDuration
{
	 DTOs.ReasonAndDurationMatrix CalculateReasonAndDurationMatrix(IEnumerable<Duration> dtDuration, IEnumerable<WorkOrder> dtWorkOrder);
}