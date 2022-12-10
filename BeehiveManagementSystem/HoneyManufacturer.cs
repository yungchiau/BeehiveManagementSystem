using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class HoneyManufacturer : Bee
    {
        public const float NECTAT_PROCESSED_PER_SHOFT = 33.15f;
        public override float CostPerShift { get { return 1.7f; } }
        public HoneyManufacturer():base("Honey Manufacturer") { }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAT_PROCESSED_PER_SHOFT);
        }
    }
}
