using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcManager manager = CalcManager.SingleTon();
            int select;
            while(true)
            {
                while (true)
                {
                    manager.MainView();
                    try
                    {
                        select = int.Parse(Console.ReadLine());
                        switch(select)
                        {

                        }
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
            }
        }
    }
}
