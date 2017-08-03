using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class MatrixQuestion : Question
    {
        public MatrixGroup MatrixGroup { get; set; }
    }

    public class MatrixGroup
    {
        public List<string> GroupName { get; set; }
        public List<string> Headers { get; set; }
        public List<string> AvailableResponses { get; set; }
    }
}
