using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMachine
{
    class CalcManager
    {
        const int maxCount = 5;
        CalcProcess[] RandomNum = new CalcProcess[maxCount];

        #region 싱글톤
        static CalcManager calcInstance;

        private CalcManager(){  }   //기본생성자

        public static CalcManager SingleTon()
        {
            if(calcInstance == null) { calcInstance = new CalcManager(); }

            return calcInstance;
        }
        #endregion
        public void MainView()
        {
            Console.WriteLine("************암산 프로그램************");
            Console.WriteLine("상(1)  |  중(2)  |  하(3)");
            Console.Write("난이도를 선택하시오. : ");
        }

        public void HardMission()
        {
            
        }
    }
}
