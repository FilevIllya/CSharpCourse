using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    //Its like real example
    public class BankTerminal
    {
        protected string id;

        public BankTerminal(string id)
        {
            this.id = id;
        }
        public virtual void Connect()
        {
            Console.WriteLine("General Conecting Protocol...");
        }
    }

    public class ModelXTerminal : BankTerminal
    {
        public ModelXTerminal(string id) : base(id) { } //call basic constuct
        public override void Connect()
        {
            base.Connect(); //its method from BankTerminal class. We can use fields and methods from first class
            Console.WriteLine("Additional actions for Model X");
        }
    }

    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id) { } //call basic constuct
        public override void Connect()
        { 
            Console.WriteLine("Additional for Model Y");
        }
    }
}
