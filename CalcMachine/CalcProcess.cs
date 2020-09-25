using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMachine
{
    public class CalcProcess
    {
        int[,] levelMaxMin = new int[3, 2] { { 1, 10 }, { 10, 100 }, { 100, 1000 } };
        Random value = new Random();
        int playerNum, comNum;

        public int RandomValue { get { return comNum; } }

        public CalcProcess() {   }
        public CalcProcess(int playerNum)
        {
            this.playerNum = playerNum;
        }

        public void RandomNum(int level)
        {
            comNum = this.value.Next(levelMaxMin[level - 1, 0], levelMaxMin[level - 1, 1]);
        }
    }
}
