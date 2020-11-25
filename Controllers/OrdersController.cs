using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OrdersApi.Controllers
{
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/orders")]
        public IActionResult GetOrders()
        {
            
            var o1 = new Order("ID1", 300);
            var o2 = new Order("ID2", 300);
            _logger.LogInformation("-------------message");
            return Ok(new List<Order> { o1, o2 });
        }

        [HttpGet]
        [Route("api/v1/account/list")]
        public IActionResult GetAccounts()
        {

            var a1 = new Account("ID1", "Account One");
            var a2 = new Account("ID2", "Account Two");
            _logger.LogInformation("-------------message");
            return Ok(new List<Account> { a1, a2 });
        }
    }



    public class Order
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }

        public Order(string id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }
    }

    public class Account
    {
        public string Id { get; set; }
        public string AccountName { get; set; }

        public Account(string id, string account)
        {
            Id = id;
            AccountName = account;
        }
    }
}
