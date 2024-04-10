using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudUsingADO.Models
{
    public class EmployeeModel
    {
        
        [Key]
        [DisplayName ("EmployeeId")]
        public int Employee_Code { get; set;}

        [DisplayName("Employee Name")]
        public string Employee_Name { get; set;}

        [DisplayName("Employee Address")]
        public string Address { get; set;}

        [DisplayName("Employee Country")]
        public string Country { get; set;}

        [DisplayName("Employee State")]
        public string State { get; set;}

        [DisplayName("Employee City")]
        public string City { get; set;}

        [DisplayName("Employee Project Assigned")]
        public string Project_Assigned { get; set;}


    }
}
