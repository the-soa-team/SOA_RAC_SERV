using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using RentACar.Bll;
using RentACar.Model.EntityModels;


namespace RentACar.Service
{
    /// <summary>
    /// Summary description for CarWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CarWebService : System.Web.Services.WebService
    {

               [WebMethod]
        public Cars InsertCar(Cars entity)
        {
            try
            {
                using (var business = new CarManager())
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
        public Cars UpdateCar(Cars entity)
        {
            try
            {
                using (var business = new CarManager())
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
        public bool DeleteCar(int id)
        {
            try
            {
                using (var business = new CarManager())
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
        public bool Delete(Cars car)
        {
            try
            {
                using (var business = new CarManager())
                {
                    business.Delete(car);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        [WebMethod]
        public Cars[] SelectAllCars()
        {
            try
            {
                using (var business = new CarManager())
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
        public Cars SelectCarById(int id)
        {
            try
            {
                using (var business = new CarManager())
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
