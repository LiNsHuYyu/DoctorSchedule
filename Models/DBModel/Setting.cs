namespace DoctorSchedule.Models{
    public class Setting{
        public int setting_id {get; set; }
        public int department_setting_id {get; set; }
        public int ward_setting_id {get; set; }
        public int doctor_setting_id {get; set; }
        public int shift {get; set; }
    }
}