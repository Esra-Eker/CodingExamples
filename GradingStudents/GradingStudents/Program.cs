using System;
using System.Collections.Generic;

namespace GradingStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            gradingStudents(grades);
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            int max = 0;
            List<int> finalGrade = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >38)
                {
                    for (int j = grades[i]; j < grades[i] + 5; j++)
                    {
                        if (j % 5 == 0)
                            max = j;
                        else
                            continue;
                    }

                    if ((max - grades[i]) < 3)
                    {
                        grades[i] = max;
                        finalGrade.Add(grades[i]);
                    }

                    else if ((max - grades[i]) == 3)
                    {
                        finalGrade.Add(grades[i]);
                    }
                    else
                    {
                        finalGrade.Add(grades[i]);
                    }
                }
                else
                {
                    finalGrade.Add(grades[i]);
                }
            }
            Console.WriteLine("---------");
            foreach (var result in finalGrade)
            {
                Console.WriteLine(result);
            }
            return finalGrade;
        }
    }
}
