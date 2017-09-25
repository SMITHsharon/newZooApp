﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZooWebApplication.DataModels
{
    public class Environment
    {
        public int EnclosureId { get; set; }
        [Required]
        public EnclosureType EnclosureType { get; set; }
        public bool IndoorEnsloure { get; set; }
        public int sqFeet { get; set; }

        public virtual List<Animal> Animals { get; set; }
    }

    public enum EnclosureType
    {
        Fencing,
        WireMesh,
        TraditionalCage,
        Aquarium
    }
}