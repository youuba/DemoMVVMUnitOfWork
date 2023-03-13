using System;
using System.Collections.Generic;

namespace DentalClinicManagement.Core.Models;

public partial class Appointment
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string AppointmentType { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;
}
