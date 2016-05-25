using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Math equations = new Math();


            int answer;
            answer = equations.Double(20);
            Console.WriteLine(answer);


        }
    }

}
