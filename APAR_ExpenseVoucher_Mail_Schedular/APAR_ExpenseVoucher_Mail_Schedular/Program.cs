using APAR_ExpenseVoucher_Mail_Schedular.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAR_EmployeeMaster_Schedular.Models;

namespace APAR_ExpenseVoucher_Mail_Schedular
{
    class Program
    {
        static void Main()
        {
            //string filename = "log\\Log.txt";
            //CustomSharePointUtility.logFile = new StreamWriter(filename);
            //CustomSharePointUtility.WriteLog("*********************************************");
            //CustomSharePointUtility.WriteLog("Reminder Mail Starts: " + DateTime.Now.ToString());
            //CustomSharePointUtility.WriteLog("*********************************************");
            //Console.WriteLine("*********************************************");
            //Console.WriteLine("Reminder Mail starts : " + DateTime.Now.ToString());
            //Console.WriteLine("*********************************************");
            List<ExpenseVoucher> SPTravelVoucher = null;
            try
            {
                var siteUrl = ConfigurationManager.AppSettings["SP_Address_Live"];
                string TestingExpenseHeaderList = ConfigurationManager.AppSettings["TestingExpenseHeaderList"];
                string EmailList = ConfigurationManager.AppSettings["EmailList"];
                string DaysDifference = ConfigurationManager.AppSettings["DaysDifference"];
                //string query = SQLUtility.ReadQuery("EmployeeMasterQuery.txt");
                SPTravelVoucher = new List<ExpenseVoucher>();
                //Task task_SPEmployeeMaster = Task.Run(() => SPTravelVoucher = CustomSharePointUtility.GetAll_TravelVoucherFromSharePoint(siteUrl, TestingTravelHeaderList));
                SPTravelVoucher = CustomSharePointUtility.GetAll_TravelVoucherFromSharePoint(siteUrl, TestingExpenseHeaderList, DaysDifference);
                //List<TravelVoucher> empMasterFinal = new List<TravelVoucher>();
                List<ExpenseVoucher> empMasterFinal = SPTravelVoucher;
                if (empMasterFinal.Count > 0)
                {
                    //CustomSharePointUtility.WriteLog("Voucher data successfully.");
                    //Console.WriteLine("Employee data synchronized successfully.");
                    var success = CustomSharePointUtility.EmailData(empMasterFinal, siteUrl, EmailList);
                    if (success)
                    {
                        //CustomSharePointUtility.WriteLog("Reminder Mail Sent Successfully.");
                        //Console.WriteLine("Reminder Mail Sent Successfully.");
                    }
                }
                else
                {
                    //CustomSharePointUtility.WriteLog("No employee data to synchronize.");
                    //Console.WriteLine("No employee data to synchronize.");
                }
            }
            catch (Exception ex)
            {
                //CustomSharePointUtility.WriteLog("Error in scheduler : " + ex.StackTrace);
                //Console.WriteLine("Error in scheduler : " + ex.StackTrace);
            }
            finally
            {
                //CustomSharePointUtility.WriteLog("*********************************************");
                //CustomSharePointUtility.WriteLog("Reminder Mail ends : " + DateTime.Now.ToString());
                //CustomSharePointUtility.WriteLog("*********************************************");
                //Console.WriteLine("*********************************************");
                //Console.WriteLine("Reminder Mail ends : " + DateTime.Now.ToString());
                //Console.WriteLine("*********************************************");
             //   CustomSharePointUtility.logFile.Close();
                //Console.ReadKey();

            }
        }
    }
}
