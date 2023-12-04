namespace DoctorSchedule.Models{
    public class Schedule{
        public int schedule_id {get; set; }
        public int department_schedule_id {get; set; }
        public int ward_schedule_id {get; set; }
        public int doctor_schedule_id {get; set; }
        public DateOnly schedule_date {get; set; }
    }
}