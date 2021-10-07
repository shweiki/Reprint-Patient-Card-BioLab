using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class CoDetailsPathsDirectory
    {
        public int Id { get; set; }
        public int MasterPathId { get; set; }
        public string Path { get; set; }
        public int BranchId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
