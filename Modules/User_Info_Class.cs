using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD502_Forms_ClassActivity_21_03_2022.Modules
{
	public abstract class User_Info_Class
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Address { get; set; }
		public string Country { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }

	}
}
