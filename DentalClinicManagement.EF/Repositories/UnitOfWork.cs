using DentalClinicManagement.Core.Interfaces;
using DentalClinicManagement.Core.Models;
using DentalClinicManagement.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace DentalClinicManagement.EF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;

        public IGenericRepository<Patient> PatientRepository { get; }

        public IGenericRepository<Appointment> AppointmentRepository { get; }

        public IGenericRepository<Treatment> TreatmentRepository { get; }

        public IGenericRepository<Invoice> InvoiceRepository { get; }

        public IGenericRepository<InvoiceItem> InvoiceItemRepository { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context   = context;
            PatientRepository = new GenericRepository<Patient>(_context);
            AppointmentRepository = new GenericRepository<Appointment>(_context);
            TreatmentRepository = new GenericRepository<Treatment>(_context);
            InvoiceRepository = new GenericRepository<Invoice>(_context);
            InvoiceItemRepository = new GenericRepository<InvoiceItem>(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        public int SaveChanges()
        {
           return _context.SaveChanges();
        }
    }
}
