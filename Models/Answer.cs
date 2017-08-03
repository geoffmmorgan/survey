using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int SurveySessionId { get; set; }
        public int QuestionId { get; set; }

        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
