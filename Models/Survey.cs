using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<SecondaryIdentifiers> SecondaryIdentifiers { get; set; }
        public SurveyStates State { get; set; }
        public bool IsComplete { get; set; }
    }

    public enum SurveyStates
    {
        Staging,
        Active,
        Closed
    }
}
