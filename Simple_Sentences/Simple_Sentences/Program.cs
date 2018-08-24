using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Sentences
{
    class Program
    {
        static void Main()
        {
            int pronounCount = Enum.GetNames(typeof(SubjectPronoun)).Length; //Counts the amount of enums.
            int pastSimpleIrregularVerbCount = Enum.GetNames(typeof(PastSimpleIrregularVerb)).Length;

            Random rnd = new Random();
            int pronounID = rnd.Next(pronounCount); //Assigns a random integer no higher than the number of enums referenced
            int pastSimpleIrregularVerbID = rnd.Next(pastSimpleIrregularVerbCount);

            SubjectPronoun pronoun = new SubjectPronoun();
            pronoun = (SubjectPronoun)pronounID;

            PastSimpleIrregularVerb verb = new PastSimpleIrregularVerb();
            verb = (PastSimpleIrregularVerb)pastSimpleIrregularVerbID;

            string sentence = (pronoun+ " " +verb);

            Console.WriteLine(sentence);
            Console.ReadLine();
        }
    }
}
