using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZooWebApplication.DataModels
{
    public class ZooKeeper
    {
        public int ZooKeeperId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public bool FullTime { get; set; }
        public DateTime StartDate { get; set; }

        public virtual List<Animal> Animals { get; set; }
    }
}