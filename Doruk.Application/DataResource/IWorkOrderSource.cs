using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doruk.Application.DataResource
{
	public  interface IWorkOrderSource
	{
		public List<Doruk.Domain.WorkOrder> GetWorkOrderByTime(DateTime dt);
	}
}
