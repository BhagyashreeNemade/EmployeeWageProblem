﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    
        public class CheckEmployee
        {
            /// <summary>
            /// Checks the employee present or not.
            /// </summary>
            public static void CheckEmployeePresentOrNot()
            {
                Random random = new Random();
                int AttendanceVariable = random.Next(2);
                int IsPresent = 1;

                if (AttendanceVariable == IsPresent)

                {
                    Console.WriteLine("Employee is Present");
                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }
            }

        }
    
    
}
