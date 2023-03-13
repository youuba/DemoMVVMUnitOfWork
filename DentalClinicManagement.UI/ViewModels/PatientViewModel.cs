using System;
using System.Windows;
using System.Windows.Input;
using DentalClinicManagement.Core.Helpers;
using DentalClinicManagement.Core.Interfaces;
using DentalClinicManagement.Core.Models;
using DentalClinicManagement.UI.Helpers;

namespace DentalClinicManagement.UI.ViewModels
{
    public class PatientViewModel : ViewModelBase<Patient>
    {
        public PatientViewModel(IUnitOfWork unitOfWork) : base(unitOfWork) { }
        //public PatientViewModel() { }

        #region Commands
        private ICommand _addcommand;
        public ICommand Addcommand
        {
            get
            {
                if (_addcommand == null)
                {
                    _addcommand = new RelayCommand(x => AddRecord());
                }
                return _addcommand;
            }
        }
        public ICommand CloseCommand { get => new RelayCommand(closeCommand); }
        private void closeCommand(object parameter)
        {
            Application.Current.Shutdown();
        }
        #endregion

        #region Methods
        protected override void AddRecord()
        {
            try
            {
                _unitOfWork.PatientRepository.Insert(ModelRecord);
                _unitOfWork.SaveChanges();
                MessageBox.Show("Inserted Successfully");
                ModelRecord = new Patient();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
        #endregion
    }
}
