using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatoca
{
	public class Booked
	{
		private string date;
		private string sessionId;
		private string pId;

		public Booked() { }
		public Booked(string date, string sessionId, string pId)
		{
			this.date = date;
			this.sessionId = sessionId;
			this.pId = pId;
		}

		public string SessionId
		{
			get { return sessionId; }
			set { sessionId = value; }
		}

		public string PId
		{
			get { return pId; }
			set { pId = value; }
		}

		public string Date
		{
			get { return date; }
			set { date = value; }
		}

	}
}
