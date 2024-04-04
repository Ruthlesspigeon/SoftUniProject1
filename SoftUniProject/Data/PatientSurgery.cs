namespace SoftUniProject.Data
{
    public class PatientSurgery
    {
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int SurgeryID { get; set; }
        public Surgery Surgery { get; set; }
    }
}
