using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class Student {

        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Firstname { get; set; }
        [StringLength(30)]
        [Required]
        public string Lastname { get; set; }
        public double GPA { get; set; }
        [ForeignKey("MajorId")]
        public int? MajorId { get; set; }
        //forgot to make public int? MajorId{get;set;}

        public virtual Major Majors { get; set; }//want to display the major for the student

        public Student() { }
    }
}
