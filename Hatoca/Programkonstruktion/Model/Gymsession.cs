using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatoca
{
	class Gymsession
	{
		private int gid;
		private string gtitle;
		private string gplace;
		private int gtime;
		private int gmaximumSpots;

		public int Gid
		{
			get { return gid; }
			set { gid = value; }
		}

		public string GTitle
		{
			get { return gtitle; }
			set { gtitle = value; }
		}

		public string GPlace
		{
			get { return gplace; }
			set { gplace = value; }
		}

		public int Time
		{
			get { return gtime; }
			set { gtime = value; }
		}

		public int GMaximumSpots
		{
			get { return gmaximumSpots; }
			set { gmaximumSpots = value; }
		}

	}
}
