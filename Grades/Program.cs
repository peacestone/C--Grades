using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
           //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello this is the grade program!");
            GradeBook book = new GradeBook();
            book.nameChanged += new NameChangedDelegate(OnNameChanged);
            book.Name = "roger's book";
            book.Name = "AWesome book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
        }
        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changed name from {args.ExistingName} to {args.NewName}");
        }
    }
}
