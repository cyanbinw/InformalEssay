using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple=true,Inherited=false)]
    public class ActionAttribute : Attribute
    {
        public bool Action { get; set; }
        public string Describe { get; set; }
        public string Version { get; set; }

        public ActionAttribute(bool action, string descruibe, string version)
        {
            this.Action = action;
            this.Describe = descruibe;
            this.Version = version;
        }
    }
}
