using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatoca
{
	class Customer
	{
		private int cpnr;
		private string cname;
		private string caddress;
		private string ctel;
		private string cmail;

		public int Cpnr
		{
			get { return cpnr; }
			set { cpnr = value; }
		}

		public string CName
		{
			get { return cname; }
			set { cname = value; }
		}

		public string CAddress
		{
			get { return caddress; }
			set { caddress = value; }
		}

		public string CTel
		{
			get { return ctel; }
			set { ctel = value; }
		}

		public string Cmail
		{
			get { return cmail; }
			set { cmail = value; }
		}
	}
}