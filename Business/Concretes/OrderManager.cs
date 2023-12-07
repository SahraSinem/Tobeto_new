using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class OrderManager : IOrderService

    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public async Task Add(Order order)
        {
            await _orderDal.AddAsync(order);
        }

        public async Task<IPaginate<Order>> GetListAsync()
        {
           return await _orderDal.GetListAsync();
        }
    }
}
