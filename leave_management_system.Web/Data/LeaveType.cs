using System.ComponentModel.DataAnnotations.Schema;

namespace leave_management_system.Web.Data
{
    public class LeaveType
    {
//ID primary key
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(150)")]
        public string Name { get; set; }
//Number of days that leave type can have
        public int NumberofDays { get; set; }
    }
}
