using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class Major {

        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Description { get; set; } 
        public int MinSat { get; set; }

        //want to all students with list of major
        //public virtual IEnumerable<Student> Students { get; set; }
        //not really good way to do this relationship because you could 
        //do this iwth a join query
        //preferred way to fix this is add [JsonIgnore] and add appropriate package
        //or just take out

        public Major() { }
    }
}
