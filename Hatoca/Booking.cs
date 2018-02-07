using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatoca
{
	public class Booking
	{
		private string date;
		private string sessionId;
		private string pId;

		public Booking()
		{
		}
		public Booking(string pId, string date, string sessionId)
		{
			this.pId = pId;
			this.date = date;
			this.sessionId = sessionId;
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
