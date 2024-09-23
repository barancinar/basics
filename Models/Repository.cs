namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() { 
                    Id = 1, 
                    Title = "Asp.Net Kursu", 
                    Image="1.png", 
                    Description = "Güzel bir kurs gibi görünyor.",
                    Tags = new string[] {"aspnet", "web geliştirme"},
                    isActive = true,
                    isHome = true },
                new Course() { 
                    Id = 2,
                    Title = "Python Kursu", 
                    Image="2.png", 
                    Description = "Başarılı olabilecek bir kurs olması yönünde ilerliyor.",
                    Tags = new string[] {"python", "temel"},
                    isActive = true,
                    isHome = true },
                new Course() { 
                    Id = 3, 
                    Title = "Django Kursu", 
                    Image="3.png", 
                    Description = "En iyi olmaya aday gibi görünyor.",
                    Tags = new string[] {"python", "temel"},
                    isActive = false,
                    isHome = true },
                new Course() { 
                    Id = 4, 
                    Title = "JavaScript Kursu", 
                    Image="4.png", 
                    Description = "Rakip kurslar arasından en iyisi olmasına rağmen geliştirilmeye ihtiyacı var.",
                    isActive = true,
                    isHome = false },
                new Course() { 
                    Id = 5, 
                    Title = "C++ Kursu", 
                    Image="2.png", 
                    Description = "Rakip kurslar arasından en iyisi.",
                    Tags = new string[] {"cpp", "gömülü"},
                    isActive = true,
                    isHome = false }


            };
        }

        public static List<Course> Courses
        {
            get { return _courses; }

        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c=>c.Id == id);
        }
    }
}