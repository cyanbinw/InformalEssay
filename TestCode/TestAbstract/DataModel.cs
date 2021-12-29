using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestAbstract
{
    public class DataModel : DataAbstract
    {
        private string Address { get; set; }

        [Action("")]
        public override void Run()
        {
            string str = this.strData;
            int number = this.intData;

            Address = "Address";

            string strAddress = Address;
            strAddress = "Name";

            str = "Data";
            number = 13;
            Console.WriteLine("strData = " + strData + " str = " + str);
            Console.WriteLine("intData = " + intData + " number = " + number);
            Console.WriteLine("Address = " + Address + " strAddress = " + strAddress);
        }
    }
}
