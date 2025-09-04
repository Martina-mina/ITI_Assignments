namespace DAY4.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // استخدمنا string.Empty لتجنب تحذير Nullable
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Manager { get; set; } = string.Empty;

    }
}
