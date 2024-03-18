using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptBuilderPattern.Models
{
    internal class Director
    {
        private ITestCaseBuilder _builder;

        public ITestCaseBuilder Builder
        {
            set { _builder = value; }
        }

        // Директор может строить несколько вариаций продукта, используя
        // одинаковые шаги построения.

        public void BuildGeneralTestCase()
        {
            this._builder.BuildSteps();
        }

        public void BuildTestCaseWithPreconditions()
        {
            this._builder.BuildPrecondition();
            this._builder.BuildSteps();
        }

        public void BuildFullTestCase()
        {
            this._builder.BuildPrecondition();
            this._builder.BuildSteps();
            this._builder.BuildExpectedResults();
        }
    }
}
