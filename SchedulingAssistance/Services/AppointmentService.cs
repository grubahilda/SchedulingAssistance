using SchedulingAssistance.Models;
using SchedulingAssistance.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using SchedulingAssistance.Helpers;

namespace SchedulingAssistance.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;

        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }


        public List<DoctorViewModel> GetDoctorList()
        {
            var doctors = (from user in _db.Users
                join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                join roles in _db.Roles.Where(x => x.Name == GetRolesHelper.Doctor) on userRoles.RoleId equals roles.Id
                select new DoctorViewModel
            {
                Id = user.Id,
                Name = user.Name
            }).ToList();

            return doctors;
        }

        public List<PatientViewModel> GetPatientList()
        {
            var doctors = (from user in _db.Users
                join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                join roles in _db.Roles.Where(x => x.Name == GetRolesHelper.Patient) on userRoles.RoleId equals roles.Id
                select new PatientViewModel
                {
                    Id = user.Id,
                    Name = user.Name
                }).ToList();

            return doctors;
        }
    }
}
