using System;
using System.Collections.Generic;

namespace DentalClinicManagement.Core.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public DateTime InvoiceDate { get; set; }

    public decimal TotalCost { get; set; }

    public virtual ICollection<InvoiceItem> InvoiceItems { get; } = new List<InvoiceItem>();

    public virtual Patient Patient { get; set; } = null!;
}
