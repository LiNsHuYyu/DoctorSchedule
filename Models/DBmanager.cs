using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DoctorSchedule.Models {
    public class DBManager {
        private string connString = "server=localhost;port=3306;user id=ShuyuLin;password=knkd16022503;database=mydb";

        public List<Doctor> GetDoctorsByDepartment(int departmentId) {
            List<Doctor> doctors = new List<Doctor>();
            try{
                using (MySqlConnection sqlConnection = new MySqlConnection(connString)) {
                    MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM doctor WHERE department_doctor_id = @departmentId", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@departmentId", departmentId);
                    sqlConnection.Open();

                    using (MySqlDataReader reader = sqlCommand.ExecuteReader()) {
                        if (reader.HasRows) {
                            while (reader.Read()) {
                                Doctor doctor = new Doctor {
                                    doctor_id = reader.GetInt32(reader.GetOrdinal("doctor_id")),
                                    doctor_name = reader.GetString(reader.GetOrdinal("doctor_name")),
                                    department_doctor_name = reader.GetInt32(reader.GetOrdinal("department_doctor_id")),
                                };
                                doctors.Add(doctor);
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"數據提取過程中出現錯誤: {ex.Message}");
            }
            return doctors;
        }
    }
}
