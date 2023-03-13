using System;
using System.Collections.Generic;

namespace DentalClinicManagement.Core.Models;

public partial class InvoiceItem
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public int TreatmentId { get; set; }

    public decimal ItemCost { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual Treatment Treatment { get; set; } = null!;
}
