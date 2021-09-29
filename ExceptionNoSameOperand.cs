using System;
//Write a program which takes two arguments and does some operation.
//If the value of the two operand is same then throw a custom exception called MyArgumentException which passes a message "Two operands cannot be same". Print the message on the caller class.
namespace ExceptionNoSameOperand
{
    class SameValueException : Exception
    {
        public SameValueException()
        {
            Console.WriteLine("Please enter two different values.");
        }
        public SameValueException(string valueException) : base(string.Format("Please enter two different values. " + valueException))
        {
            
        }
    }
    class OperationArgs : EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
        public int add { get; set; }
        public int min { get; set; }
        public int x { get; set; }
        public double div { get; set; }
        public OperationArgs(int a, int b, int add, int min, int x, double div)
        {
            this.a = a;
            this.b = b;
            this.add = add;
            this.min = min;
            this.x = x;
            this.div = div;
        }
    }
    class Publisher
    {
        public event EventHandler<OperationArgs> send;
        public void Operations(int a, int b)
        {
            int add = a + b;
            int min = a - b;
            int x = a * b;
            int div = a * b;
            OperationArgs arg = new OperationArgs(a,b,add,min,x,div);
            if(send != null)
            {
                send(this, arg);//raise event
            }
        }
    }
    class ExceptionNoSameOperand
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 1st number:");
            int input1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int input2 = Int32.Parse(Console.ReadLine());

            if (input1 != input2)
            {
                try
                {
                    Publisher publisher = new Publisher();
                    publisher.send += Publisher_send;//subscribe
                    publisher.Operations(input1, input2);//store ur inputs and bring them to other class method  
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("Unable to divide by zero. " + ex);
                }                        
            }
            else
            {
                throw new SameValueException();
            }                       
        }

        private static void Publisher_send(object sender, OperationArgs e)
        {
            Console.WriteLine("Addition: " + e.add);
            Console.WriteLine("Subtraction: " + e.min);
            Console.WriteLine("Multiplication: " + e.x);
            Console.WriteLine("Division: " + e.div);
        }
    }
}
