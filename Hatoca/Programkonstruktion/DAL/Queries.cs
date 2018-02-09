using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatoca
{
	public class Queries
	{
		public string getCustomer()
		{
			return "select * from Customer where cpnr = ? ";
		}

		public string getCustomerToTable() {
			return "select cpnr as 'Customer pnr' upper(cname) as 'Name', " + "upper(caddress) as 'Address' from Customer where cpnr = ?";
		}
		
		public string getGymsession()
		{
			return "select * from Gymsession where gid = ?";
		}

		public string getInstructor()
		{
			return "select * from Instructor where iid = ?";
		}

		public string addCustomer()
		{
			return "insert into Customer values (?,?,?,?,?)";
		}

		public string addGymsession()
		{
			return "insert into Gymsession values (?,?,?,?,?)";
		}










	}
}
