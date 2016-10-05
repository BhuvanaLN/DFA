using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dfa_set_operation
{
    class State
    {
        public string name = null;
        public string stateForZero = null;
        public string stateForOne = null;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfStateN1 = 0;
            int NoOfStateN2 = 0;

            List<State> StateListQ1=new List<State>();
            List<State> StateListQ2=new List<State>();
            List<State> StateListQ=new List<State>();


            Console.WriteLine("No of states for Q1");
            NoOfStateN1 = int.Parse(Console.ReadLine());

            Console.WriteLine("No of states for Q2");
            NoOfStateN2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < NoOfStateN1; i++)
            {
                State obj1 = new State();
                obj1.name = "q" + i;
                Console.WriteLine("enter states for zero and one for " + obj1.name);
                obj1.stateForZero = Console.ReadLine();
                obj1.stateForOne = Console.ReadLine();
                StateListQ1.Add(obj1);
                

            }
            for (int i = 0; i < NoOfStateN2; i++)
            {
                State obj1 = new State();
                obj1.name = "r" + i;
                Console.WriteLine("enter states for zero and one for " + obj1.name);
                obj1.stateForZero = Console.ReadLine();
                obj1.stateForOne = Console.ReadLine();
                StateListQ2.Add(obj1);

            }

            //
            int NoofStatesFinal = NoOfStateN1 * NoOfStateN2;
            for (int i = 0; i < NoOfStateN1; i++)
            {
                for (int j = 0; j < NoOfStateN2; j++)
                {
                    State obj = new State();
                    obj.name = StateListQ1[i].name + StateListQ2[j].name;
                    obj.stateForOne = StateListQ1[i].stateForOne + StateListQ2[j].stateForOne;
                    obj.stateForZero = StateListQ1[i].stateForZero + StateListQ2[j].stateForZero;
                    StateListQ.Add(obj);
                    Console.WriteLine(obj.name);
                }

            }

            for (int i = 0; i < StateListQ.Count; i++)
            {
               // Console.WriteLine(StateListQ[i].name + "--0-->" + StateListQ[i].stateForZero + " ; " + StateListQ[i].name + "--1-->" + StateListQ[i].stateForOne);
                Console.WriteLine(StateListQ[i].name + " " + StateListQ[i].stateForZero + " "+ StateListQ[i].stateForOne);
            
            }


            Console.ReadLine();

        }
    }
}
