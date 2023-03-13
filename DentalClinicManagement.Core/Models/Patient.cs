using DentalClinicManagement.Core.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;


namespace DentalClinicManagement.Core.Models;
public partial class Patient : PropertyChangedNotifier, IDataErrorInfo
{
    private int id;
    private string firstName = null!;
    private string lastName = null!;
    private string birthDate = null!;
    private string phoneNumber = null!;
    private string address = null!;
    public int Id { get => id; set => SetProperty(ref id, value); }
    public string FirstName { get => firstName; set => SetProperty(ref firstName, value); }
    public string LastName { get => lastName; set => SetProperty(ref lastName, value); }
    public string BirthDate { get => birthDate; set => SetProperty(ref birthDate, value); }
    public string PhoneNumber { get => phoneNumber; set => SetProperty(ref phoneNumber, value); }
    public string Address { get => address; set => SetProperty(ref address, value); }


    private ICollection<Appointment> _appointments = new List<Appointment>();
    public virtual ICollection<Appointment> Appointments
    {
        get => _appointments;
        set => SetProperty(ref _appointments, value);
    }

    private ICollection<Invoice> _invoices = new List<Invoice>();
    public virtual ICollection<Invoice> Invoices
    {
        get => _invoices;
        set => SetProperty(ref _invoices, value);
    }

    #region Validation
    public string Error => string.Empty;

    public string this[string columnName]
    {
        get
        {
            string result = string.Empty;
            switch (columnName)
            {
                case nameof(FirstName):
                    if (string.IsNullOrEmpty(FirstName)) result = columnName+" is required!"; break;
                case nameof(LastName):
                    if (string.IsNullOrEmpty(LastName)) result = columnName + " is required!"; break;
                case nameof(BirthDate):
                    if (string.IsNullOrEmpty(BirthDate)) result = columnName+ " is required!"; break;
                case (nameof(PhoneNumber)):
                   if (string.IsNullOrEmpty(PhoneNumber)|| !Regex.Match(PhoneNumber, @"^\d{10}").Success) result = columnName + " format is invalid!"; break;
                case nameof(Address):
                    if (string.IsNullOrEmpty(address)) result = columnName + " is required!"; break;
            }
            return result;
        }
    }
 
    #endregion
}
