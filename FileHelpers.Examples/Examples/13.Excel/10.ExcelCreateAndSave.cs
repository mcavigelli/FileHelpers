using FileHelpers;
using FileHelpers.ExcelNPOIStorage;
using NUnit.Framework;

namespace Examples
{
    //-> Name: Create excel storage and save it.
    //-> Description: Shows how to create excel storage, fill it with object data and save
    [TestFixture]
    public class ExcelCreateAndSave
    {
        [Test]
        public void Run()
        {
            // Create an excel storage for specific class
            // By default start row/column is 2/B (index 1)
            var storage = new ExcelNPOIStorage(typeof(Student));

            // Set storage file name -> that will be excel output file name
            // Extension must be .xlsx or .xls
            storage.FileName = "Students.xlsx";

            // Sheet name is not required. By default sheet name will be "Sheet0"
            storage.SheetName = "Students";
            storage.ColumnsHeaders.Add("Student number");
            storage.ColumnsHeaders.Add("Student name");
            storage.ColumnsHeaders.Add("Course name");

            // Test data
            const int Count = 3;
            var students = new Student[Count];
            students[0] = CreateStudent(0, "Chuck Norris", "Karate");
            students[1] = CreateStudent(1, "Steven Seagal", "Aikido");
            students[2] = CreateStudent(2, "Dennis Ritchie", "Programming");

            // Insert students to excel storage
            // This method will save out excel file
            storage.InsertRecords(students);
        }

        private static Student CreateStudent(int studentNumber, string fullName, string course)
        {
            return new Student
            {
                StudentNumber = studentNumber,
                FullName = fullName,
                Course = course
            };
        }

        [DelimitedRecord("")]
        public class Student
        {
            public int StudentNumber { get; set; }

            public string FullName { get; set; }

            public string Course { get; set; }
        }
    }
}