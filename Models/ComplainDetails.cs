namespace HospitalManegement.Models
{
    public class ComplainDetails
    {

        public string id { get; set; }
        public string DOB { get; set; }
        public string ChiefComplaint { get; set; }
        public bool b1 { get; set; }
        public bool b2 { get; set; }
        public bool b3 { get; set; }
        public bool b4 { get; set; }
        public bool b5 { get; set; }
        public bool b6 { get; set; }
        public bool b7 { get; set; }
        public bool b8 { get; set; }
        public string AdditionalInformations { get; set; }

        public string BookingDoctorID { set; get; }
        public BookingDoctor BookingDoctor { set; get; }

    }
}
