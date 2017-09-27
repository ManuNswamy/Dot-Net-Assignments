using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService22_09
{
   

    public static class Logger
    {

        public enum LogInfo
        {
            Error = 0,
            Debug = 1,
        }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       
        public static void logMessage(LogInfo log_type,string message)
        {
            switch (log_type)
            {
                case LogInfo.Error:log.Error(message);
                    break;
                case LogInfo.Debug:
                    log.Debug(message);
                    break;
                default:
                    break;
            }
            
        }
    }
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
       
        public EmployeeResponse GetEmployeeDetailById(EmployeeRequest empRequest)
        {
            if(empRequest.key == "admin")
            {
                Employee empDetail = new Employee();
                empDetail.ID = 1;
                empDetail.Name = "Harshada";
                empDetail.Salary = 1000;
                empDetail.Age = 22;

                Admin adminDetail = new Admin();
                adminDetail.ID = 2;
                adminDetail.Name = "HarshadaA";
                adminDetail.Salary = 1000;
                adminDetail.Age = 22;
                adminDetail.Admin_Username = "manuA";

                Manager managerDetail = new Manager();
                managerDetail.ID = 3;
                managerDetail.Name = "HarshadaM";
                managerDetail.Salary = 1000;
                managerDetail.Age = 22;
                managerDetail.Manager_Username = "manuM";

                Department deptDetails = new Department();
                deptDetails.DepartmentName = "Research";
                deptDetails.DepartmentID = 1;
                Logger.logMessage(Logger.LogInfo.Error, "Error Message");
                return new EmployeeResponse() { CompanyName = "Xoriant", Emp = empDetail,Dept = deptDetails,Admin = adminDetail,Manager= managerDetail};
            }
            else
            {
                return null;
            }
           
        }
    }
}
