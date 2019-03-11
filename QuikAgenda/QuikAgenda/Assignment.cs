using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuikAgenda
{
    public class Assignment
    {
        public DateTime duedate;
        public string Name;
        public string Info;
        public string Teacher;
        public string Class;
        public string[] Periods;

        public string ToDataString()
        {
            string toret = Name + "," + Info + "," + Teacher + "," + Class + "," + duedate.Month + "/" + duedate.Day + "/" + duedate.Year+",";
            foreach (string p in Periods)
            {
                toret = toret + p + ".";
            }
            return toret;
        }

        public string ToTxtShortDisplayString()
        {
            string toret = "Name: " + Tools.CutString(Name,50) + "|Teacher: " + Tools.CutString(Teacher,15) + "|Class: "+Tools.CutString(Class,20)+"|DueDate:" + duedate.ToShortDateString() + "|Periods:";
            foreach(string p in Periods)
            {
                toret = toret + " " + p;
            }
            return toret;
        }

        public string ToTxtLongDisplayString()
        {
            string toret = "Periods:";
            foreach (string p in Periods)
            {
                toret = toret + " " + p;
            }
            return "Name: " + Name + "\r\n\r\nClass: " + Class +"\r\n"+toret+"\r\nDueDate: " + duedate.ToLongDateString() + "\r\nInformation: "+ Info; 
        }

        static public Assignment Parse(string dataline)
        {
            string[] args = dataline.Split(',');
            string[] dateargs = args[4].Split('/');
            string[] periodargs = args[5].Split('.');
            return new Assignment(args[0], args[1], args[2],args[3], new DateTime(int.Parse(dateargs[2]),int.Parse(dateargs[0]),int.Parse(dateargs[1])),periodargs);
        }

        public Assignment(string name, string info, string teacher,string Class, DateTime duedate,string[] Periods)
        {
            this.Name = name;
            this.Info = info;
            this.Teacher = teacher;
            this.Class = Class;
            this.duedate = duedate;
            this.Periods = Periods;
        }
    }
}
