using SWD502_Forms_ClassActivity_21_03_2022.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SWD502_Forms_ClassActivity_21_03_2022.Modules
{
	class User_Login_Class : User_Info_Class
	{
		private string SelectQuiry { get; set; }

		public string CreateSelectQuiry()
		{
			return "select count(*) from [dbo].[User] where [UserName]='"+UserName+"'and [Password]='"+Password+"'";
		}
		public string ReturnSelectQuiry()
		{
			SelectQuiry = CreateSelectQuiry();
			return SelectQuiry;
		}
		public int ValidateLoginInput() 
		{
			try
			{
				int result=0;
				DataConnection_Class DataCon = new DataConnection_Class();
				DataCon.Open();
				result = DataCon.ExecuteReader(ReturnSelectQuiry());
				DataCon.Close();
				return result;
			}
			catch (Exception ex)
			{
				return -1;
			}
			
		}
	}
}
