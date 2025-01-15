using System;
using BlingBlongApp;
using NumberSequenceApp;
namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            BlingBlong blingBlong = new BlingBlong();
            blingBlong.printBlingBlong();

            Sequence sequence = new Sequence();
            sequence.PrintSequence(8);
        }
    }
}