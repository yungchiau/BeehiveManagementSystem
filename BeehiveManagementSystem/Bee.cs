using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
 // this class describes different bees,
 // they do different jobs, change works and eat honey
    internal class Bee
    {
        public string Job { get; private set; }
        public virtual float CostPerShift { get; }
        public Bee(string job) {
            Job = job;
        }


        public void WorkTheNextShift() {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
               DoJob();
            }
        }
        protected virtual void DoJob()
        {
            /* it will over write by subclasses */
        }


    }
}
