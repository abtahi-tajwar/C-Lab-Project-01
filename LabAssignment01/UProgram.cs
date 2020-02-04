using System;
using System.IO;


namespace LabAssignment01
{
    class UProgram
    {
        private String pname, dhead, degrees;
        public static int Count = 0;

        public UProgram()
        {
            String s;
            using (StreamReader sr = new StreamReader(@"UProgram\Serial.txt"))
            {
                s = sr.ReadLine();
            }
            Count = Int32.Parse(s);
            Count++;
        }

        public void setProgramName(String name)
        {
            pname = name;
        }
        public void setDepartmentHead(String name)
        {
            dhead = name;
        }
        public void setDegrees(String name)
        {
            degrees = name;
        }

        public void showUProgramInfo()
        {
            String s;
            using (StreamReader sr = new StreamReader(@"UProgram\Data.txt"))
            {
                s = sr.ReadToEnd();
            }
            Console.WriteLine(s);
            //Console.WriteLine("Program Name = " + pname + "\n");
            //Console.WriteLine("Department Head = " + dhead + "\n");
            //Console.WriteLine("Degrees = " + degrees + "\n");
        }
        public void setRecord()
        {
            //int serial = 0;
            String s;
            using (StreamWriter sw = new StreamWriter(@"UProgram\Data.txt", true))
            {
                sw.WriteLine("#" + Count);
                sw.WriteLine("Program Name = " + pname + "\n");
                sw.WriteLine("Department Head = " + dhead + "\n");
                sw.WriteLine("Degrees = " + degrees + "\n\n");

            }
            using (StreamWriter sr = new StreamWriter(@"UProgram\Serial.txt"))
            {
                sr.WriteLine(Count);
            }
        }
        public void Clear()
        {
            using (StreamWriter sw = new StreamWriter(@"UProgram\Data.txt"))
            {
                sw.WriteLine("");
            }
            using (StreamWriter sw = new StreamWriter(@"UProgram\Serial.txt"))
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
                using (StreamReader sr2 = new StreamReader("UProgram/Serial.txt"))
                {
                    serial = sr2.ReadLine();
                    Serial = Int32.Parse(serial);
                }
                Serial2 = Int32.Parse(sr.ReadLine());
                using (StreamWriter sw = new StreamWriter("UProgram/Data.txt", true))
                {
                    for (int i = 0; i < Serial2; i++)
                    {
                        sw.WriteLine("#" + Serial);
                        sw.WriteLine("Program Name = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Department Head = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Degrees = " + sr.ReadLine() + "\n\n");
                        Serial++;
                    }
                }
                using (StreamWriter sw = new StreamWriter("UProgram/Serial.txt"))
                {
                    sw.WriteLine(Serial);
                }
            }
            Console.WriteLine("Inserted");
        }
    }
}
