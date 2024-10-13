using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doruk.Application.DataResource
{
	public  interface IDurationSource
	{
		public List<Doruk.Domain.Duration> GetDurationByDate(DateTime startDate);

	}
}
