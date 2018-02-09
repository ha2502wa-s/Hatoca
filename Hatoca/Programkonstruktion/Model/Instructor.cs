using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatoca
{
	class Instructor
	{
		private int instructorId;
		private string name;
		public int InstructorId
		{
			get { return instructorId; }
			set { instructorId = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
}
