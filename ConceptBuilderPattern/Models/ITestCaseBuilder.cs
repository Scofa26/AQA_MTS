using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptBuilderPattern.Models
{
    internal class ITestCaseBuilder
    {
        void BuildPrecondition();

        void BuildSteps();

        void BuildExpectedResults();
    }
}
