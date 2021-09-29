using System;
//Write a program which uses the EventHandler delagate to notify the caller using a custom eventArgs.
//In the custom eventargs you should have your Message and an exception object to notify whether exception occured or not. 
namespace EventHandlerCustomEventArgs
{
    class CustomArgs : EventArgs
    {
        public string abc { get; set; }
        public CustomArgs(string abc)
        {
            this.abc = abc;
        }
    } 
    class Publisher
    {
        public event EventHandler<CustomArgs> send;
        public void Methodtest(string test)
        {
            string testString = test;
            CustomArgs customArgs = new CustomArgs(test);
            if (send != null)
            {
                send(this, customArgs);//raise event
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string input = Console.ReadLine();
            Publisher publisher = new Publisher();
            publisher.send += Publisher_send;
            publisher.Methodtest(input);
        }

        private static void Publisher_send(object sender, CustomArgs e)
        {
            Console.WriteLine("Your string is: " + e.abc);
        }
    }
}
