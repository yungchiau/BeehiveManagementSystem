using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Queen
    {
       /// <summary>
       /// Expand worker array and add a Bee reference
       /// </summary>
       /// <param name="worker"> A bee which will add in worker array</param>
       /// 

        private void AddWorker(Bee worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassiginedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }

    }
}
