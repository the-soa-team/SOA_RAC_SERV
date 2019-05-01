using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using RentACar.Bll.Concretes;
using RentACar.Model.EntityModels;


namespace RentACar.Service
{
    /// <summary>
    /// Summary description for EmployeeWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmployeeWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Employees InsertEmployee(Employees entity)
        {
            try
            {
                using (var business = new EmployeeManager())
                {
                    business.Insert(entity);
                }
                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [WebMethod]
        public Employees UpdateEmployee(Employees entity)
        {
            try
            {
                using (var business = new EmployeeManager())
                {
                    business.Update(entity);
                }
                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [WebMethod]
        public bool DeleteEmployee(int id)
        {
            try
            {
                using (var business = new EmployeeManager())
                {
                    business.DeletedById(id);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public bool Delete(Employees emp)
        {
            try
            {
                using (var business = new EmployeeManager())
                {
                    business.Delete(emp);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        [WebMethod]
        public Employees[] SelectAllEmployees()
        {
            try
            {
                using (var business = new EmployeeManager())
                {
                    return business.SelectAll().ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public Employees SelectEmployeeById(int id)
        {
            try
            {
                using (var business = new EmployeeManager())
                {
                    return business.SelectById(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public Employees EmployeeLogin(string UserName, string Password)
        {
            try
            {
                using (var business = new EmployeeManager())
                {
                    return business.EmployeeLogin(UserName,Password);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
