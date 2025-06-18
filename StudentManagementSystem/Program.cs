namespace StudentManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudenetManagement myObj = new StudenetManagement();

            while (true)
            {
                Console.Write("\nEnter student Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter student Grade: ");
                double grade = Convert.ToDouble(Console.ReadLine());
                myObj.addStudent(name, grade);

                Console.Write("\n\nAdd Another data:Press any Key or For Exit:Press \"N\": ");
                string exitToken = Console.ReadLine().ToUpper();
                if (exitToken == "N") { break; }
            }

            myObj.displayStudent();

            //while (true)
            //{
            //    Console.WriteLine("\nEnter the student name to remove: ");
            //    string removeName = Console.ReadLine();
            //    myObj.removeStudent(removeName);
            //    Console.Write("\n\nPress D to display OR Press N to exit: ");
            //    string exitToken1 = Console.ReadLine().ToUpper();  
            //    if (exitToken1 == "N") { break; } 
            //    else if(exitToken1 == "D")  { myObj.displayStudent(); Console.WriteLine("After "); }
            //}


            //Console.Write("Enter Student name for search: ");
            //string serachName = Console.ReadLine();
            //myObj.SearchStudent(serachName);

            Console.WriteLine("Enter the Grade to Filter >= : ");
            double filterGrade = Convert.ToDouble(Console.ReadLine()); 
            myObj.FilterByGrade(filterGrade);



        }
         



    }
}
