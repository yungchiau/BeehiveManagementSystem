﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class EggCare:Bee
    {
        public const float CARE_PROGESS_PER_SHIFT = 0.15f;
        public override float CostPerShift { get { return 1.35f; } }
        private Queen queen;

        public EggCare(Queen queen) : base("Egg Care") {
            this.queen = queen;
        }

        protected override void DoJob()
        { queen.CareForEggs(CARE_PROGESS_PER_SHIFT); }
            
        
    }
}
