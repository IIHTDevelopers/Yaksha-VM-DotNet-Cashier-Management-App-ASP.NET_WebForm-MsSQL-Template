using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CashierManagementApp.DAL.Interfaces;

namespace CashierManagementApp.DAL.Services
{
    public class CashierRepository : Interfaces.ICashierRepository
    {
        private CashierDbContext _context;

        public CashierRepository(CashierDbContext context)
        {
            _context = context;
        }

        public Model.CashierModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
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
    }
}