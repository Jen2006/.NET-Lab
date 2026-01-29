using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class STUDENT
    {
        [Required]
        public int USN { get; set; }

        [Required]
        public string Name { get; set; }

        public int Sub1 { get; set; }

        public int Sub2 { get; set; }

        public int Sub3 { get; set; }






    }
}
