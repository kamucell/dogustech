using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doruk.Application.DataResource;
using Doruk.Domain;

namespace Doruk.Infracture.Data
{
	public  class DurationSource : IDurationSource
	{
		public List<Duration> GetDurationByDate(DateTime startDate)
		{
			return new List<Duration>
			{
				new Duration("Mola", DateTime.Parse("2017-01-01 10:00:00"), DateTime.Parse("2017-01-01 10:10:00")),
				new Duration("Arıza", DateTime.Parse("2017-01-01 10:30:00"), DateTime.Parse("2017-01-01 11:00:00")),
               // new Duration("Happy Work Order", DateTime.Parse("2017-01-01 11:15:00"), DateTime.Parse("2017-01-01 11:45:00")),
                new Duration("Mola", DateTime.Parse("2017-01-01 12:00:00"), DateTime.Parse("2017-01-01 12:30:00")),
				new Duration("Mola", DateTime.Parse("2017-01-01 14:00:00"), DateTime.Parse("2017-01-01 14:10:00")),
				new Duration("Setup", DateTime.Parse("2017-01-01 15:00:00"), DateTime.Parse("2017-01-01 16:30:00")),
				new Duration("Mola", DateTime.Parse("2017-01-01 18:00:00"), DateTime.Parse("2017-01-01 18:10:00")),
				new Duration("Mola", DateTime.Parse("2017-01-01 20:00:00"), DateTime.Parse("2017-01-01 20:30:00")),
				new Duration("Mola", DateTime.Parse("2017-01-01 22:00:00"), DateTime.Parse("2017-01-01 22:10:00")),
				new Duration("Arge", DateTime.Parse("2017-01-01 23:00:00"), DateTime.Parse("2017-01-02 08:30:00")),
				new Duration("Mola", DateTime.Parse("2017-01-02 10:00:00"), DateTime.Parse("2017-01-02 10:10:00")),
				new Duration("Mola", DateTime.Parse("2017-01-02 12:00:00"), DateTime.Parse("2017-01-02 12:30:00")),
				new Duration("Arıza", DateTime.Parse("2017-01-02 13:00:00"), DateTime.Parse("2017-01-02 13:45:00")),
				new Duration("Mola", DateTime.Parse("2017-01-02 14:00:00"), DateTime.Parse("2017-01-02 14:10:00")),
				new Duration("Mola", DateTime.Parse("2017-01-02 18:00:00"), DateTime.Parse("2017-01-02 18:10:00")),
				new Duration("Arge", DateTime.Parse("2017-01-02 20:00:00"), DateTime.Parse("2017-01-03 02:10:00")),
				new Duration("Mola", DateTime.Parse("2017-01-03 04:00:00"), DateTime.Parse("2017-01-03 04:30:00")),
				new Duration("Setup", DateTime.Parse("2017-01-03 06:00:00"), DateTime.Parse("2017-01-03 09:30:00")),
              //  new Duration("Happy Work Order 2", DateTime.Parse("2017-01-03 09:45:00"), DateTime.Parse("2017-01-03 09:59:00")),
                new Duration("Mola", DateTime.Parse("2017-01-03 10:00:00"), DateTime.Parse("2017-01-03 10:10:00")),
				new Duration("Mola", DateTime.Parse("2017-01-03 12:00:00"), DateTime.Parse("2017-01-03 12:30:00")),
				new Duration("Mola", DateTime.Parse("2017-01-03 14:00:00"), DateTime.Parse("2017-01-03 14:10:00")),
				new Duration("Arıza", DateTime.Parse("2017-01-03 15:00:00"), DateTime.Parse("2017-01-03 18:45:00")),
				new Duration("Mola", DateTime.Parse("2017-01-03 20:00:00"), DateTime.Parse("2017-01-03 20:30:00")),
				new Duration("Mola", DateTime.Parse("2017-01-03 22:00:00"), DateTime.Parse("2017-01-03 22:10:00"))
			}.OrderBy(f => f.StartTime).ThenBy(f => f.EndTime).ToList();
		}

		
	}
}
