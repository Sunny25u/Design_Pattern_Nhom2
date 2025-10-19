using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DPM225407_NguyenHuuDuy_MyWord_21_Strategy
{
    public class SortedList : List<Student>
    {
        // Sets sort strategy
        public ISortStrategy SortStrategy { get; set; } = null!;
        // Perform sort
        public void SortStudents()
        {
            SortStrategy.Sort(this);
            // Display sort results
            foreach (var student in this)
            {
                WriteLine($" {student.Name}");
            }
            WriteLine();
        }
    }
    /// <summary>
    /// Represents a student
    /// </summary>
    public record Student(string Name, string Ssn);
}
