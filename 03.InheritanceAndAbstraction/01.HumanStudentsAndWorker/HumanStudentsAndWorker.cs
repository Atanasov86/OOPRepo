namespace _01.HumanStudentsAndWorker
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Xml.Xsl;

    public class HumanStudentsAndWorker
    {
        public static void Main()
        {
            List<Student> myStudents = new List<Student>()
                                           {
                                               new Student("Pesho", "Peshev", "A12345"),
                                               new Student("Mitko", "Mitkov", "A12346"),
                                               new Student("Peshka", "Peshkova", "B12344"),
                                               new Student("Gosho", "Goshev", "B12345"),
                                               new Student("Nadejda", "Miteva", "A12347"),
                                               new Student("Stela", "Gluhcheva", "A12348"),
                                               new Student("Tonio", "Tonev", "B12346"),
                                               new Student("Tania", "Taneva", "A12341"),
                                               new Student("Spaska", "Spaskova", "A12340"),
                                               new Student("Jelio", "Jelev", "B12340")
                                           };
            var sortedStudents = myStudents.OrderBy(student => student.FacultyNumber);
            Console.WriteLine("Students: ");
            foreach (var sortedStudent in sortedStudents)
            {
                Console.WriteLine(sortedStudent);
            }

            List<Worker> myWorkers = new List<Worker>()
                                         {
                                             new Worker("Pesho", "Peshev", 123.45m, 6.5),
                                             new Worker("Mitko", "Mitkov", 56.45m, 2.5),
                                             new Worker("Peshka", "Peshkova", 500.45m, 10),
                                             new Worker("Gosho", "Goshev", 98.10m, 4),
                                             new Worker("Nadejda", "Miteva", 450.45m, 8),
                                             new Worker("Stela", "Gluhcheva", 550m, 12),
                                             new Worker("Tonio", "Tonev", 200m, 6.5),
                                             new Worker("Tania", "Taneva", 315.13m, 6),
                                             new Worker("Spaska", "Spaskova", 187.77m, 5),
                                             new Worker("Jelio", "Jelev", 420.34m, 7.5)
                                         };
            var sortedWorkers = myWorkers.OrderByDescending(worker => worker.MoneyPerHours());
            Console.WriteLine("Workers: ");
            foreach (var sortedWorker in sortedWorkers)
            {
                Console.WriteLine("{0} SalaryPerHour: {1:F2}", sortedWorker, sortedWorker.MoneyPerHours());
            }

            List<Human> mergedLists = new List<Human>();
            mergedLists.AddRange(myStudents);
            mergedLists.AddRange(myWorkers);
            Console.WriteLine("MergetLists: ");
            var sortedMergedList = mergedLists.OrderBy(fname => fname.FirstName).ThenBy(lname => lname.LastName);

            foreach (var human in mergedLists)
            {
                Console.WriteLine(human);
            }
        }
    }
}
