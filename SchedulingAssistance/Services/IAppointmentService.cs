using System.Collections.Generic;
using SchedulingAssistance.Models.ViewModels;

namespace SchedulingAssistance.Services
{
    public interface IAppointmentService
    {
        public List<DoctorViewModel> GetDoctorList();
        public List<PatientViewModel> GetPatientList();
    }
}
