using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OktaExample.Models
{
    public class Prescription
    {

        
        public int Id { get; set; }
        [Display(Name ="Prescription Title")]
        public string PrescriptionTitle { get; set; }
        [Display(Name = "Prescription Content")]
        public string PrescriptionContent { get; set; }
        [Display(Name = "Prescription Comments")]
        public string PrescriptionComments { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Posted")]
        public DateTime DatePosted { get; set; }

    }
}
