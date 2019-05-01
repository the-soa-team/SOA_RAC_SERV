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
    /// Summary description for TransactionWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TransactionWebService : System.Web.Services.WebService
    {
        
        [WebMethod]
        public Transactions InsertTransaction(Transactions entity)
        {
            try
            {
                using (var business = new TransactionManager())
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
        public Transactions UpdateTransaction(Transactions entity)
        {
            try
            {
                using (var business = new TransactionManager())
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
        public bool DeleteTransaction(int id)
        {
            try
            {
                using (var business = new TransactionManager())
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
        public bool Delete(Transactions tran)
        {
            try
            {
                using (var business = new TransactionManager())
                {
                    business.Delete(tran);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        [WebMethod]
        public Transactions[] SelectAllTransactions()
        {
            try
            {
                using (var business = new TransactionManager())
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
        public Transactions SelectTransactionById(int id)
        {
            try
            {
                using (var business = new TransactionManager())
                {
                    return business.SelectById(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //TODO:: BLL katmanındaki işleme göre düzenlenmesi gerekecek
        //Parametre olarak sınıflar değil id ler alınması gerekebilir
        [WebMethod]
        public bool Rent(Transactions tran,Cars car,Customers cust,DateTime first,DateTime second)
        {
            try
            {
                using (var business = new TransactionManager())
                {
                    return business.Rent(tran, car, cust, first, second);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        //TODO:: BLL katmanındaki işleme göre düzenlenmesi gerekecek
        //Parametre olarak sınıflar değil id ler alınması gerekebilir
        [WebMethod]
        public bool GiveBack(Cars car, Customers cust)
        {
            try
            {
                using (var business = new TransactionManager())
                {
                    return business.GiveBack(car, cust);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        

    }
}