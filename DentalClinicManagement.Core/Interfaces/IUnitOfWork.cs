using DentalClinicManagement.Core.Models;

namespace DentalClinicManagement.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepository<Patient> PatientRepository { get; }
        IGenericRepository<Appointment> AppointmentRepository { get; }
        IGenericRepository<Treatment> TreatmentRepository { get; }
        IGenericRepository<Invoice> InvoiceRepository { get; }
        IGenericRepository<InvoiceItem> InvoiceItemRepository { get; }
        int SaveChanges();
    }
}
