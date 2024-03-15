using System;
using System.Collections.Generic;

namespace KanbanWithCrudCustomAdaptor.Models;

public partial class OrderDetail
{
    public int EmployeeId { get; set; }

    public string? ShipName { get; set; }

    public string? ShipCity { get; set; }
}
