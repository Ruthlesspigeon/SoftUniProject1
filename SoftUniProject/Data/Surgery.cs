namespace SoftUniProject.Data
{
    public class Surgery
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SurgeryTypeID { get; set; }
        public SurgeryType SurgeryType { get; set; }
        public DateTime Date { get; set; }
    }
}
