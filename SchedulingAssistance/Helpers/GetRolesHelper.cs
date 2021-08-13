using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SchedulingAssistance.Helpers
{
    public static class GetRolesHelper
    {
        public static string Admin = "Admin";
        public static string Doctor = "Doctor";
        public static string Patient = "Patient";

        public static List<SelectListItem> GetRolesForDropdown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem {Value = GetRolesHelper.Admin, Text = GetRolesHelper.Admin},
                new SelectListItem {Value = GetRolesHelper.Doctor, Text = GetRolesHelper.Doctor},
                new SelectListItem {Value = GetRolesHelper.Patient, Text = GetRolesHelper.Patient}
            };
        }

    }
}
