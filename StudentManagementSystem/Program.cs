namespace StudentManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudenetManagement myObj = new StudenetManagement();
            Console.WriteLine("===================== Student Database ===================");
            while (true)
            { 
                Console.WriteLine("1.To Add student\n2.To remove Student\n3.To display\n4.To Update Detials\n5.To search\n6.To Filter\nEnter the Option: ");

                int switchInput = Convert.ToInt32(Console.ReadLine());
                
                switch (switchInput)
                {
                    case 1:
                        while (true) { 
                        Console.Write("\nEnter student Name: ");
                        string name1 = Console.ReadLine();
                        Console.Write("Enter student Grade: ");
                        double grade = Convert.ToDouble(Console.ReadLine());

                        myObj.addStudent(name1, grade);

                            Console.Write("\nPress any key to add data or \"D\" for Display or \"N\" for Exit: ");
                        string exitToken = Console.ReadLine().ToUpper();
                            if (exitToken == "N") { break; }
                            else if(exitToken == "D") { myObj.displayStudent(); break; }

                        }
                    break;

                    case 2:
                        while (true)
                        {
                            Console.WriteLine("\nEnter the student name to remove: ");
                            string removeName = Console.ReadLine();

                            myObj.removeStudent(removeName);

                            Console.Write("\n\nPress D to display OR Press N to exit: ");
                            string exitToken1 = Console.ReadLine().ToUpper();

                            if (exitToken1 == "N") { break; }
                            else if (exitToken1 == "D") { myObj.displayStudent(); Console.WriteLine("After "); }
                        }

                        break;


                    case 3:
                        myObj.displayStudent();
                        break;

                    case 4:
                        Console.Write("\nEnter the Name: ");
                        string name = Console.ReadLine();
                        Console.Write("\nEnter the new Grade: ");
                        double newGrade = Convert.ToDouble(Console.ReadLine());
                        myObj.updateStudent(name,newGrade);

                        //Console.WriteLine("Data");
                        break;

                    case 5:
                        Console.Write("Enter Student name for search: ");
                        string serachName = Console.ReadLine();
                        myObj.SearchStudent(serachName);

                        break;

                    case 6:
                        Console.WriteLine("Enter the Grade to Filter >= : ");
                        double filterGrade = Convert.ToDouble(Console.ReadLine());
                        myObj.FilterByGrade(filterGrade);

                        break;

                    default:
                        Console.WriteLine("Plz Press (1 to 6) only");
                        break;
                
                }
            }


            //Without loop:(Like static)

            //    Console.Write("\nEnter student Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Enter student Grade: ");
            //    double grade = Convert.ToDouble(Console.ReadLine());
            //    myObj.addStudent(name, grade);

            //    Console.Write("\n\nAdd Another data:Press any Key or For Exit:Press \"N\": ");
            //    string exitToken = Console.ReadLine().ToUpper();
            //    if (exitToken == "N") { break; }
            //}

            //myObj.displayStudent();

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


            //Console.Write("\nEnter the Name: ");
            //string name = Console.ReadLine();
            //Console.Write("\nEnter the new Grade: ");
            //double newGrade = Convert.ToDouble(Console.ReadLine());
            //myObj.updateStudent(name, newGrade);


            //Console.Write("Enter Student name for search: ");
            //string serachName = Console.ReadLine();
            //myObj.SearchStudent(serachName);

            //Console.WriteLine("Enter the Grade to Filter >= : ");
            //double filterGrade = Convert.ToDouble(Console.ReadLine()); 
            //myObj.FilterByGrade(filterGrade);



        }




    }
}
