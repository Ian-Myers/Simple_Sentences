using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Sentences
{
    public class SentenceStructure
    {
        public SubjectPronoun SubjectPronoun { get; set; }
        public PastSimpleIrregularVerb PastSimpleIrregularVerb { get; set; }
    }
    public enum SubjectPronoun
    {
        I,
        He,
        She,
        We,
        You,
        They,
        It
    }

    public enum PastSimpleIrregularVerb //For now this will only contain verbs that make sense in a two-word sentence.
    {
        Ran,
        Woke,
        Dove,
        Drove,
        Drank,
        Ate,
        Flew,
        Froze,
        Grew,
        Hid,
        Hurt,
        Knew,
        Left,
        Paid,
        Read,
        Rang,
        Said,
        Sang,
        Sat,
        Slept,
        Spoke,
        Stood,
        Thought,
        Understood,
        Won
    }
}
