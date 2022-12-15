using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
    namespace AngularCURDOperations.BsinessLogic
{
    public class TblEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public int age { get; set; }
        public DateTime Doj { get; set; }
        public string Gender { get; set; }
        public int IsMarried { get; set; }
        public int IsActive { get; set; }
        public int DesignationID { get; set; }

        [NotMapped]
        public string Designation { get; set; }



    }
}
