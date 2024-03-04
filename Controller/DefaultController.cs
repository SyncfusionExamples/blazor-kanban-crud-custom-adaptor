using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using KanbanWithCrudCustomAdaptor.Models;
using Newtonsoft.Json;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using System.Collections;

namespace KanbanWithCrudCustomAdaptor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        OrderDataAccessLayer db = new OrderDataAccessLayer();
        // GET: api/Default
        [HttpGet]
        public IQueryable<OrderDetail> Get()
        {
            IQueryable<OrderDetail> data = db.GetAllOrders();   //call the method to fetch data from db and return to client
            return data;
        }
    }
}