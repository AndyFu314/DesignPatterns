using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ResumeClone
{
    class WorkExperience : ICloneable
    {
        private string workDate;
        public string WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }

        public string Company { get; set; }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
