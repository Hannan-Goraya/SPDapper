using System.ComponentModel.DataAnnotations.Schema;

namespace SPDapper.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

       
        public int DepartmentId { get; set; }


        [ForeignKey("DepaetmentId")]
        public virtual Department Department { get; set; }
    }
}
