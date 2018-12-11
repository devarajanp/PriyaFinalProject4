using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    
        public static class courseclass1
        {
            private static string stdname;
            private static int nocourse;
            private static DateTime dateTime;
            private static string type1;
        private static string t;



            public static void gets1()
            {
                courseclass2.sets1(stdname);

            }

            public static void sets1(String sname)
            {
                stdname = sname;
                gets1();
            }

            public static void getnocours()// this method is used to set variables in form
            {
                courseclass2.setsnocours(nocourse);

            }

            public static void setsnocours(int course) // this method is used to set course number in the form. 
            {
                nocourse = course;
                getnocours();
            }

            public static void getdate() // this method is used to set date 
        {
                courseclass2.setdate(dateTime);

            }

            public static void setdate(DateTime dtTime) //this method is used to set data  in class 
        {
                dateTime = dtTime;
                getdate();
            }

            public static void gettype()
            {
                courseclass2.settype(type1);

            }

            public static void settype(string Type)
            {
                type1 = Type;
                gettype();
            }

        public static void getnumber() // this method is used to set variables in form
        {
            courseclass2.setno(t);

        }

        public static void setnumber(string T) // this method is used to set number in form
        {
            t = T;
            getnumber();
        }
    }
    }

