using System;
using System.IO;

namespace LabAssignment01
{
    class Degree
    {
        public static int Count = 0;
        private String dname, credits;

        public Degree()
        {
            String s;
            using (StreamReader sr = new StreamReader(@"Degree\Serial.txt"))
            {
                s = sr.ReadLine();
            }
            Count = Int32.Parse(s);
            Count++;
        }

        public void setDegreeName(String name)
        {
            dname = name;
        }
        public void setCreditsRequired(String name)
        {
            credits = name;
        }
        public void showDegrees()
        {
            String s;
            using (StreamReader sr = new StreamReader(@"UProgram\Data.txt"))
            {
                s = sr.ReadToEnd();
            }
            Console.WriteLine(s);
            //Console.WriteLine("Degree Name = " + dname + "\n");
            //Console.WriteLine("Credits Required = " + credits + "\n");
        }
        public void setRecord()
        {
            //int serial = 0;
            String s;
            using (StreamWriter sw = new StreamWriter(@"Degree\Data.txt", true))
            {
                sw.WriteLine("#" + Count);
                sw.WriteLine("Degree Name = " + dname + "\n");
                sw.WriteLine("Credits Required = " + credits + "\n\n");

            }
            using (StreamWriter sr = new StreamWriter(@"Degree\Serial.txt"))
            {
                sr.WriteLine(Count);
            }
        }
        public void Clear()
        {
            using (StreamWriter sw = new StreamWriter(@"Degree\Data.txt"))
            {
                sw.WriteLine("");
            }
            using (StreamWriter sw = new StreamWriter(@"Degree\Serial.txt"))
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
                using (StreamReader sr2 = new StreamReader("Degree/Serial.txt"))
                {
                    serial = sr2.ReadLine();
                    Serial = Int32.Parse(serial);
                }
                Serial2 = Int32.Parse(sr.ReadLine());
                using (StreamWriter sw = new StreamWriter("Degree/Data.txt", true))
                {
                    for (int i = 0; i < Serial2; i++)
                    {
                        sw.WriteLine("#" + Serial);
                        sw.WriteLine("Degree Name = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Credits Required = " + sr.ReadLine() + "\n\n");
                        Serial++;
                    }
                }
                using (StreamWriter sw = new StreamWriter("Degree/Serial.txt"))
                {
                    sw.WriteLine(Serial);
                }
            }
            Console.WriteLine("Inserted");
        }
    }
}
