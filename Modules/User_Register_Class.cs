using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD502_Forms_ClassActivity_21_03_2022.Controls;

namespace SWD502_Forms_ClassActivity_21_03_2022.Modules
{
	class User_Register_Class: User_Info_Class
	{
		private string SaveQuiry { get; set; }
		private string CreateSaveQuiry() 
		{
			return "Insert into [dbo].[User]([Name],[DateOfBirth],[Address],[Country],[UserName],[Password])" +
				"values('"+Name+"','"+ DateOfBirth.ToString("yyyy-MM-dd") + "','"+Address+"','"+Country+ "','" + UserName + "','" + Password + "');";
		}
		public string ReturnSaveQuiry()
		{
			SaveQuiry = CreateSaveQuiry();
			return SaveQuiry;
		}
		public bool Save_Registration()
		{
			try
			{
				DataConnection_Class DataCon = new DataConnection_Class();
				DataCon.Open();
				DataCon.ExecuteNonQuery(ReturnSaveQuiry());
				DataCon.Close();
				return true;
			}
			catch (Exception ex)
			{
				
				return false;
			}
			
		}
	}
}
