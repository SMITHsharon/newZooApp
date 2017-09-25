using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZooWebApplication.DataModels
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        public string AnimalType { get; set; }
        public SpeciesType SpeciesType { get; set; }
        public string CountryOfOrigin { get; set; }

        public virtual int ZooKeeperId { get; set; }
        public virtual Environment Enclosure { get; set; }
    }

    public enum SpeciesType
    {
        Reptile,
        Mammal,
        Bird,
        Fish
    }
}