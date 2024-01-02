using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CashierManagementApp.DAL.Interfaces;
using CashierManagementApp.Model;

namespace CashierManagementApp.DAL.Services
{
    public class CashierService : Interfaces.ICashierService
    {
        private Interfaces.ICashierRepository _repository;

        public CashierService(Interfaces.ICashierRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Add()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Update()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Delete()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public CashierModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}