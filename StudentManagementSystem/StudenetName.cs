using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class StudenetManagement
    {
        List<string> studentName = new List<string>();
        Dictionary<string,double> studentGrade = new Dictionary<string,double>();

        public void addStudent(string name,double grade) 
        { 
            studentName.Add(name);
            studentGrade[name] = grade;
            Console.WriteLine($"Data inserted...!");

        }
        public void displayStudent() 
        {
            Console.WriteLine("\nStudent List");
            foreach (var name in studentName)
            {
                Console.WriteLine($"Name:\t{name},Grade:\t{studentGrade[name]}");
            }
        }

        public void removeStudent(string name) 
        {
            if (studentName.Contains(name))
            {
                studentName.Remove(name);
                studentGrade.Remove(name);
                Console.WriteLine($"Student {name} is removed...!");
            }
            else { Console.WriteLine("Student Not found....!"); }

        }
        public void updateStudent(string name,double newgrade) 
        {
            if (studentGrade.ContainsKey(name))
            {
                studentGrade[name] = newgrade;
                Console.WriteLine("Student grade is updated!!"); 
            }
            else 
            {
                Console.WriteLine("Student Not Found!!!");
            }
        
        }

        public void SearchStudent(string keyword)
        {
            var result = studentName.Where(n => n.ToLower().Contains(keyword.ToLower()));

            Console.WriteLine("\nSearch Result:");
            foreach (var name in result)
            {
                Console.WriteLine($"Name: {name}, Grade: {studentGrade[name]}");
            }

            if (!result.Any())
                Console.WriteLine("No student found.");
        }


    }
}
