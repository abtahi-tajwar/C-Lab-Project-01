using System;
using LabAssignment01;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            var a = "";
            String b;
            DateTime dob;
            while (true)
            {
                Console.WriteLine("1. Enter Student Info ");
                Console.WriteLine("2. Enter Teacher Info ");
                Console.WriteLine("3. Enter Uprogram Info ");
                Console.WriteLine("4. Enter Degree Info ");
                Console.WriteLine("5. Enter Course Info \n");

                Console.WriteLine("6. Show Student Info ");
                Console.WriteLine("7. Show Teacher Info ");
                Console.WriteLine("8. Show Uprogram Info ");
                Console.WriteLine("9. Show Degree Info ");                
                Console.WriteLine("10. Show Course Info \n");

                Console.WriteLine("11. Clear History");
                Console.WriteLine("12. Input from file");

                Console.WriteLine("0. Exit ");



                a = Console.ReadLine();
                try
                {
                    option = Int32.Parse(a);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please give a valid input");
                }               

                if (option == 1)
                {
                    Student student = new Student();

                    Console.WriteLine("#" + Student.Count + "\n");
                    Console.WriteLine("Enter First Name: ");
                    a = Console.ReadLine();
                    student.setFirstName(a);
                    Console.WriteLine("Enter Last Name: ");
                    a = Console.ReadLine();
                    student.setLastName(a);
                    Console.WriteLine("Enter Date of Birth: ");
                    a = Console.ReadLine();
                    try
                    {
                        dob = DateTime.Parse(a);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    a = Console.ReadLine();
                    Console.WriteLine("Enter Address Line 01: ");
                    student.setAddress01(a);

                    a = Console.ReadLine();
                    Console.WriteLine("Enter Address Line 02: ");
                    student.setAddress02(a);

                    a = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    student.setCity(a);

                    a = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    student.setState(a);

                    a = Console.ReadLine();
                    Console.WriteLine("Enter Zip/Postal: ");
                    student.setZip(a);

                    a = Console.ReadLine();
                    Console.WriteLine("Enter Coutnry: ");
                    student.setCountry(a);
                    student.setStudentRecord();
                }
                else if (option == 2)
                {
                    Teacher teacher = new Teacher();
                    Console.WriteLine("#" + Teacher.Count + "\n");

                    Console.WriteLine("Enter First Name: ");
                    a = Console.ReadLine();
                    teacher.setFirstName(a);
                    Console.WriteLine("Enter Last Name: ");
                    a = Console.ReadLine();
                    teacher.setLastName(a);
                    Console.WriteLine("Enter Date of Birth: ");
                    a = Console.ReadLine();

                    try
                    {
                        dob = DateTime.Parse(a);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    Console.WriteLine("Enter Address Line 01: ");
                    a = Console.ReadLine();
                    teacher.setAddress01(a);


                    Console.WriteLine("Enter Address Line 02: ");
                    a = Console.ReadLine();
                    teacher.setAddress02(a);

                    a = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    teacher.setCity(a);


                    Console.WriteLine("Enter State: ");
                    a = Console.ReadLine();
                    teacher.setState(a);


                    Console.WriteLine("Enter Zip/Postal: ");
                    a = Console.ReadLine();
                    teacher.setZip(a);


                    Console.WriteLine("Enter Coutnry: ");
                    a = Console.ReadLine();
                    teacher.setCountry(a);

                    teacher.setTeacherRecord();
                }

                else if (option == 3)
                {
                    UProgram upr = new UProgram();
                    Console.WriteLine("#" + UProgram.Count + "\n");

                    Console.WriteLine("Enter Program Name: ");
                    a = Console.ReadLine();
                    upr.setProgramName(a);

                    Console.WriteLine("Enter Department Head: ");
                    a = Console.ReadLine();
                    upr.setDepartmentHead(a);

                    Console.WriteLine("Enter Degrees: ");
                    a = Console.ReadLine();
                    upr.setDegrees(a);
                    upr.setRecord();

                }

                else if (option == 4)
                {
                    Degree degree = new Degree();
                    Console.WriteLine("#" + Degree.Count + "\n");

                    Console.WriteLine("Enter Degree Name: ");
                    a = Console.ReadLine();
                    degree.setDegreeName(a);

                    Console.WriteLine("Enter Credits Required: ");
                    a = Console.ReadLine();
                    degree.setCreditsRequired(a);
                    degree.setRecord();
                }
                else if (option == 5)
                {
                    Course course = new Course();
                    Console.WriteLine("#" + Course.Count + "\n");

                    Console.WriteLine("Enter Course Name: ");
                    a = Console.ReadLine();
                    course.setCourseName(a);

                    Console.WriteLine("Enter Credits: ");
                    a = Console.ReadLine();
                    course.setCredits(a);

                    Console.WriteLine("Enter Duration In a Week: ");
                    a = Console.ReadLine();
                    course.setDuration(a);

                    Console.WriteLine("Enter Teacher: ");
                    a = Console.ReadLine();
                    course.setTeacher(a);
                    course.setRecord();

                }
                else if (option == 6)
                {
                    Student student = new Student();
                    student.showInfo();
                }
                else if (option == 7)
                {
                    Teacher teacher = new Teacher();
                    teacher.showInfo();
                }
                else if (option == 8)
                {
                    UProgram uprogram = new UProgram();
                    uprogram.showUProgramInfo();
                }
                else if (option == 9)
                {
                    Degree degree = new Degree();
                    degree.showDegrees();
                }
                else if (option == 10)
                {
                    Course course = new Course();
                    course.showCourseInformation();
                }
                else if (option == 11)
                {
                    String s = "";
                    Console.WriteLine("1. Student Info");
                    Console.WriteLine("2. Teacher Info");
                    Console.WriteLine("3. UProgram Info");
                    Console.WriteLine("4. Degree Info");
                    Console.WriteLine("5. Course Info");

                    a = Console.ReadLine();
                    option = Int32.Parse(a);

                    if (option == 1)
                    {
                        Student st = new Student();
                        st.Clear();
                    }
                    else if (option == 2)
                    {
                        Teacher tc = new Teacher();
                        tc.Clear();
                    }
                    else if (option == 3)
                    {
                        UProgram up = new UProgram();
                        up.Clear();
                    }
                    else if (option == 4)
                    {
                        Degree dg = new Degree();
                        dg.Clear();
                    }
                    else if (option == 5)
                    {
                        Course cs = new Course();
                        cs.Clear();
                    }
                }
                else if (option == 12)
                {                   

                    Console.WriteLine("1. Student info");
                    Console.WriteLine("2. Teacher info");
                    Console.WriteLine("3. UProgram info");
                    Console.WriteLine("4. Degree info");
                    Console.WriteLine("5. Course info");

                    a = Console.ReadLine();
                    option = Int32.Parse(a);

                    if (option == 1)
                    {
                        Console.WriteLine("Enter file name from where to take input from: ");
                        String s = Console.ReadLine();

                        Student student = new Student();
                        student.InputFromFile(s);
                    }
                    else if(option == 2)
                    {
                        Console.WriteLine("Enter file name from where to take input from: ");
                        String s = Console.ReadLine();

                        Teacher student = new Teacher();
                        student.InputFromFile(s);
                    }
                    else if(option == 3)
                    {
                        Console.WriteLine("Enter file name from where to take input from: ");
                        String s = Console.ReadLine();

                        UProgram student = new UProgram();
                        student.InputFromFile(s);
                    }
                    else if(option == 4)
                    {
                        Console.WriteLine("Enter file name from where to take input from: ");
                        String s = Console.ReadLine();

                        Degree student = new Degree();
                        student.InputFromFile(s);
                    }
                    else if(option == 5)
                    {
                        Console.WriteLine("Enter file name from where to take input from: ");
                        String s = Console.ReadLine();

                        Course student = new Course();
                        student.InputFromFile(s);
                    }
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }
    }
    
    
    

    
    
}