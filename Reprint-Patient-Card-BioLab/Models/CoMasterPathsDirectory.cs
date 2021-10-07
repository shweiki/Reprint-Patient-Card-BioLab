using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class CoMasterPathsDirectory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool SeperateByBranch { get; set; }
        public string DefaultPath { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
