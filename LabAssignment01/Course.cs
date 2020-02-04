using System;
using System.IO;

namespace LabAssignment01
{
    class Course
    {
        public static int Count = 0;
        private String cname, credits, duration, teacher;

        public Course()
        {
            String s;
            using (StreamReader sr = new StreamReader(@"Course\Serial.txt"))
            {
                s = sr.ReadLine();
            }
            Count = Int32.Parse(s);
            Count++;
        }

        public void setCourseName(String name)
        {
            cname = name;
        }
        public void setCredits(String name)
        {
            credits = name;
        }
        public void setDuration(String name)
        {
            duration = name;
        }
        public void setTeacher(String name)
        {
            teacher = name;
        }

        public void showCourseInformation()
        {
            String s;
            using (StreamReader sr = new StreamReader(@"Course\Data.txt"))
            {
                s = sr.ReadToEnd();
            }
            Console.WriteLine(s);
         
        }
        public void setRecord()
        {
            //int serial = 0;
            String s;
            using (StreamWriter sw = new StreamWriter(@"Course\Data.txt", true))
            {
                sw.WriteLine("#" + Count);
                sw.WriteLine("Coruse Name = " + cname + "\n");
                sw.WriteLine("Credits = " + credits + "\n");
                sw.WriteLine("Duration In Week = " + duration + "\n");
                sw.WriteLine("Teacher = " + teacher + "\n\n");

            }
            using (StreamWriter sr = new StreamWriter(@"Course\Serial.txt"))
            {
                sr.WriteLine(Count);
            }
        }
        public void Clear()
        {
            using (StreamWriter sw = new StreamWriter(@"Course\Data.txt"))
            {
                sw.WriteLine("");
            }
            using (StreamWriter sw = new StreamWriter(@"Course\Serial.txt"))
            {
                sw.WriteLine(0);
            }
            Console.WriteLine("Cleared");
        }
        public void InputFromFile(String s)
        {
            String file = "";
            if (s.Substring(s.Length - 4, 4).Equals(".txt"))
            {
                file = s;
            }
            else
            {
                s = s + ".txt";
            }
            using (StreamReader sr = new StreamReader(s))
            {
                String serial = "";
                Int32 Serial = 0;
                Int32 Serial2 = 0;
                using (StreamReader sr2 = new StreamReader("Course/Serial.txt"))
                {
                    serial = sr2.ReadLine();
                    Serial = Int32.Parse(serial);
                }
                Serial2 = Int32.Parse(sr.ReadLine());
                using (StreamWriter sw = new StreamWriter("Course/Data.txt", true))
                {
                    for (int i = 0; i < Serial2; i++)
                    {
                        sw.WriteLine("#" + Serial);
                        sw.WriteLine("Coruse Name = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Credits = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Duration In Week = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Teacher = " + sr.ReadLine() + "\n\n");
                        Serial++;
                    }
                }
                using (StreamWriter sw = new StreamWriter("Course/Serial.txt"))
                {
                    sw.WriteLine(Serial);
                }
                Console.WriteLine("Inserted");
            }

        }
    }
}
