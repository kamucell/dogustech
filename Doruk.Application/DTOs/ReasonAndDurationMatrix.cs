namespace Doruk.Application.DTOs;

public class ReasonAndDurationMatrix
{
    public ReasonAndDurationMatrix()
    {
	    Reason = new List<string>();
	    WorkOrderDuration = new Dictionary<string, Dictionary<string, double>>();
    }
    public List<string> Reason { get; set; }
	public Dictionary<string, Dictionary<string, double>> WorkOrderDuration { get; set; }
}