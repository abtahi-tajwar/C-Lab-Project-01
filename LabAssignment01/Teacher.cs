﻿using System;
using System.IO;

namespace LabAssignment01
{
    class Teacher
    {
        private String firstName, lastName, add01, add02, city, state, zip, country;
        private DateTime dob;
        public static int Count = 0;

        public Teacher()
        {
            String s;
            using (StreamReader sr = new StreamReader(@"Teacher\Serial.txt"))
            {
                s = sr.ReadLine();
            }
            Count = Int32.Parse(s);
            Count++;
        }

        public void setFirstName(String name)
        {
            firstName = name;
        }
        public void setLastName(String name)
        {
            lastName = name;
        }
        public void setDateOfBirth(DateTime name)
        {
            dob = name;
        }
        public void setAddress01(String name)
        {
            add01 = name;
        }
        public void setAddress02(String name)
        {
            add02 = name;
        }
        public void setCity(String name)
        {
            city = name;
        }
        public void setState(String name)
        {
            state = name;
        }
        public void setZip(String name)
        {
            zip = name;
        }
        public void setCountry(String name)
        {
            country = name;
        }

        public void showInfo()
        {
            String s;
            using (StreamReader sr = new StreamReader(@"Teacher\Data.txt"))
            {
                s = sr.ReadToEnd();
            }
            Console.WriteLine(s);
            //Console.WriteLine("First Name = " + firstName + "\n");
            //Console.WriteLine("Last Name = " + lastName + "\n");
            //Console.WriteLine("Date of Birth = " + dob + "\n");
            //Console.WriteLine("Address Line 01 = " + add01 + "\n");
            //Console.WriteLine("Address Line 02 = " + add02 + "\n");
            //Console.WriteLine("City = " + city + "\n");
            //Console.WriteLine("State = " + state + "\n");
            //Console.WriteLine("Zip = " + zip + "\n");
            //Console.WriteLine("Country = " + country + "\n");
        }
        public void setTeacherRecord()
        {
            //int serial = 0;
            String s;
            using (StreamWriter sw = new StreamWriter(@"Teacher\Data.txt", true))
            {
                sw.WriteLine("#" + Count);
                sw.WriteLine("First Name = " + firstName + "\n");
                sw.WriteLine("Last Name = " + lastName + "\n");
                sw.WriteLine("Date of Birth = " + dob + "\n");
                sw.WriteLine("Address Line 01 = " + add01 + "\n");
                sw.WriteLine("Address Line 02 = " + add02 + "\n");
                sw.WriteLine("City = " + city + "\n");
                sw.WriteLine("State = " + state + "\n");
                sw.WriteLine("Zip = " + zip + "\n");
                sw.WriteLine("Country = " + country + "\n\n");
            }
            using (StreamWriter sr = new StreamWriter(@"Teacher\Serial.txt"))
            {
                sr.WriteLine(Count);
            }
        }
        public void Clear()
        {
            using (StreamWriter sw = new StreamWriter(@"Teacher\Data.txt"))
            {
                sw.WriteLine("");
            }
            using (StreamWriter sw = new StreamWriter(@"Teacher\Serial.txt"))
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
                using (StreamReader sr2 = new StreamReader("Teacher/Serial.txt"))
                {
                    serial = sr2.ReadLine();
                    Serial = Int32.Parse(serial);
                }
                Serial2 = Int32.Parse(sr.ReadLine());
                using (StreamWriter sw = new StreamWriter("Teacher/Data.txt", true))
                {
                    for (int i = 0; i < Serial2; i++)
                    {
                        sw.WriteLine("#" + Serial);
                        sw.WriteLine("First Name = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Last Name = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Date of Birth = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Address Line 01 = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Address Line 02 = " + sr.ReadLine() + "\n");
                        sw.WriteLine("City = " + sr.ReadLine() + "\n");
                        sw.WriteLine("State = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Zip = " + sr.ReadLine() + "\n");
                        sw.WriteLine("Country = " + sr.ReadLine() + "\n\n");
                        Serial++;
                    }
                }
                using (StreamWriter sw = new StreamWriter("Teacher/Serial.txt"))
                {
                    sw.WriteLine(Serial);
                }
            }
            Console.WriteLine("Inserted");
        }
    }
}
