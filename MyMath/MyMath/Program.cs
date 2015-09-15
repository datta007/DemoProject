using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Program:IMobile
    {
        static void Main(string[] args)
        {

            IMobile _imobile = new Program();
            _imobile.MakeCall();
            _imobile.ReceivedCall();


            Console.ReadLine();
        }

        public void MakeCall()
        {
            Console.WriteLine("MakeCall Called");
        }

        public void ReceivedCall()
        {
            Console.WriteLine("Received Called");
        }
    }
    public interface ICalculator
    {
        int Add(int a, int b);
        string Mode { get; set; }
        event EventHandler PoweringUp;

    }
    public interface ICommand
    {
        void Execute();
        event EventHandler Executed;
    }
    public class SomethingThatNeedsACommand : ICommand
    {
        ICommand command;
        public SomethingThatNeedsACommand(ICommand command)
        {
            this.command = command;            
        }
        public void DoAnything()
        {
            command.Execute();
        }
        public void DontDoAnything()
        { 
        
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public event EventHandler Executed;
    }
   

   
}
