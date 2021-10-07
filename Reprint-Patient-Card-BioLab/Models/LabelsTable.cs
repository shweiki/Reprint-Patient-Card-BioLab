using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class LabelsTable
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string FormName { get; set; }
        public string Label { get; set; }
        public string English { get; set; }
        public string Georgia { get; set; }
        public int? LabelType { get; set; }
        public decimal IdLocal { get; set; }
    }
}
