using DentalClinicManagement.Core.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
namespace DentalClinicManagement.Core.Helpers
{
    public class ViewModelBase<T> : PropertyChangedNotifier
    {     
        protected readonly IUnitOfWork _unitOfWork;

        private T _modelRecord  ;
        public T ModelRecord { get => _modelRecord; set => SetProperty(ref _modelRecord, value);}
        public ViewModelBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _modelRecord = Activator.CreateInstance<T>();
        }
        public ViewModelBase() { }
        protected virtual void AddRecord() {    
        }
    }
}
