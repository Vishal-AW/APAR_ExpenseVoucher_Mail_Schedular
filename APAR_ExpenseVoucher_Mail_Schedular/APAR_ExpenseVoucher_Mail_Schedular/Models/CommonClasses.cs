using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAR_ExpenseVoucher_Mail_Schedular.Models
{


    public class ExpenseVoucher
    {
        public int Id { get; set; }
        public string ExpVoucherNo { get; set; }
        public string CreatorName { get; set; }
        public string CreatorDepartment { get; set; }
        public string CreatorLocation { get; set; }
        public string Destination { get; set; }
        public string VisitDate { get; set; }
        public string StatusCode { get; set; }
        public string StatusName { get; set; }
        public string AssignUser { get; set; }
        public string MultipleApprover { get; set; }
        public string CreationDate { get; set; }
        public string FunctionalHead { get; set; }
        public string SequenceNo { get; set; }
        public string AssignDate { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string Designation { get; set; }
        public string ActionTaken { get; set; }
        public string CompanyCode { get; set; }
        public string DivisionName { get; set; }
        public string ActiveYear { get; set; }
        public string Modified { get; set; }
        //public string TravelType { get; set; }
        public string CurrentApprove { get; set; }
        public string AccountApprover { get; set; }
        public string AccountUserApproved { get; set; }

    }



}
