using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderdal)
        {
            _orderDal = orderdal;

        }
        public List<Order> GetAll()
        {
           return _orderDal.GetAll();
        }

        public List<Order> GetAllByCustomerId(string customerId)
        {
            return _orderDal.GetAll(o => o.CustomerId == customerId);
        }
    }
}
