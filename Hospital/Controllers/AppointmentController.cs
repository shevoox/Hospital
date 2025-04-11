using Hospital.Data;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _Context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var Appointment = _Context.Appointments;
            return View(Appointment.ToList());
        }
        public IActionResult Book(string DoctorName)
        {
            return View(model: DoctorName);
        }
        public IActionResult CompletAppointment(string PatientName, string DoctorName, DateOnly Date, TimeOnly? Time)
        {


            _Context.Add(new Appointment { PatientName = PatientName, DoctorName = DoctorName, Date = Date, Time = Time });
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
