﻿using Medicio.DAL.Models;
using Medicio.PL.Areas.Dashboard.ViewModels.AppointmentVIMO;
using System.Numerics;

namespace Medicio.PL.Models
{
    public class HomeViewModel
    {
        public List<Appointment> Appointments { get; set; }
        public List<Departments> Departments { get; set; }
        public List<Doctors> Doctors { get; set; }
        public List<Features> Features { get; set; }
        public List<Pricing> PricingPlans { get; set; }
        public List<Questions> FAQ { get; set; }
        public List<Service> Services { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Testimonials> Testimonials { get; set; }
        public List<AppointmentFormVM> AppointmentFormVM { get; set; } // أو أي نوع من البيانات التي تحتاجهاpublic class HomeViewModel

    // Other existing properties...

    public int DoctorId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime AppointmentDate { get; set; } // Add this property
        public string Message { get; set; }

        // You may also want to include lists for Departments and Doctors
    


}
}
