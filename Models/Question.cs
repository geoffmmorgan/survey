using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public abstract class Question
    {
        public int QuestionId { get; set; }
        public QuestionTypes QuestionType { get; set; }
        public int Order { get; set; }
        public Uri ImageUri { get; set; }
        public string QuestionText { get; set; }
        public string IsLocalized { get; set; }

        public int? TemplatedQuestionId { get; set; }
    }

    public enum QuestionTypes
    {
        RadioButton,
        MultipleChoice,
        FreeText,
        Matrix
    }
}
