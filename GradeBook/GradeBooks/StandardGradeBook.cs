using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
   public class StandardGradeBook : BaseGradeBook
    {
        // :base(name) allows us to access the parameter in the BaseGradeBook class.
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Standard;
        }

    }
}
