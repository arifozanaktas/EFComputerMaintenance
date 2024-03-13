using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFComputerMaintenance.Models;
public class ServiceStatus : BaseModel
{
    public string StatusName { get; set; }
    public string? StatusDescription { get; set; }
    [ForeignKey("StaffId")]
    public int StaffId { get; set; }
    public Staff Staff { get; set; }
}
