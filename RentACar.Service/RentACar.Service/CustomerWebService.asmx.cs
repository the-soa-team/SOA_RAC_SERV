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
    /// Summary description for CustomerWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Customers InsertCustomer(Customers entity)
        {
            try
            {
                using (var business = new CustomerManager())
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
        public Customers UpdateCustomer(Customers entity)
        {
            try
            {
                using (var business = new CustomerManager())
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
        public bool DeleteCustomer(int id)
        {
            try
            {
                using (var business = new CustomerManager())
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
        public bool Delete(Customers cust)
        {
            try
            {
                using (var business = new CustomerManager())
                {
                    business.Delete(cust);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        [WebMethod]
        public Customers[] SelectAllCustomers()
        {
            try
            {
                using (var business = new CustomerManager())
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
        public Customers SelectCustomerById(int id)
        {
            try
            {
                using (var business = new CustomerManager())
                {
                    return business.SelectById(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
