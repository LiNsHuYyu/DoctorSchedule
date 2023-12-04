namespace DoctorSchedule.Models{
    public class DoctorUnfavDate{
        public int doctor_unfav_date_id {get; set; }
        public DateOnly unfav_date { get; set;}
        public int doctor_doctor_unfav_date_id { get; set;}
    }
}