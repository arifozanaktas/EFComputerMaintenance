using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFComputerMaintenance.Models;
public class Invoice : BaseModel
{
    [ForeignKey("ServiceRecordId")]
    public int ServiceRecordId { get; set; }
    public ServiceRecord ServiceRecord { get; set; }
    public DateTime? PaymentDate { get; set; }
    public double TotalPrice { get; set; }
}
