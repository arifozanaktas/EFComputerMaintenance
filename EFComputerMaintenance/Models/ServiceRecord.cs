using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFComputerMaintenance.Models;
public class ServiceRecord : BaseModel
{
    [ForeignKey("CustomerId")]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public string DeviceType { get; set; }
    public string DeviceBrand { get; set; }
    public string DeviceModel { get; set; }
    public string SerialNumber { get; set; }
    public string FaultDescription { get; set; }
    public DateTime AcceptanceDate { get; set; }
    public DateTime EstimatedComplationDate { get; set; }
    [ForeignKey("ServiceStatusId")]
    public int ServiceStatusId { get; set; }
    public ServiceStatus ServiceStatus { get; set; }

}
