using System;
using System.Collections.Generic;

namespace DentalClinicManagement.Core.Models;

public partial class Treatment
{
    public int Id { get; set; }

    public string TreatmentName { get; set; } = null!;

    public decimal TreatmentCost { get; set; }

    public virtual ICollection<InvoiceItem> InvoiceItems { get; } = new List<InvoiceItem>();
}
