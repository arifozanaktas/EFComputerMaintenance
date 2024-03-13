using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFComputerMaintenance.Models;
public class SparePart : BaseModel
{
    public string Name { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int? StockQuantity { get; set; }
    public double? Price { get; set; }
}
