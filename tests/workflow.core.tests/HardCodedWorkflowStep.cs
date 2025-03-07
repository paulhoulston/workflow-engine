using System;
using Xunit;
using Workflow.Core;

namespace Workflow.Core.Tests
{
    class HardCodedWorkflowStep : WorkflowStep
    {
        class HardCodedRule : Workflow.Core.WorkflowStep.IAmARule
        {
            bool _stepResult;

            public HardCodedRule(bool stepResult)
            {
                _stepResult = stepResult;
            }

            public bool Evaluate() => _stepResult;
        }

        public HardCodedWorkflowStep(
            bool stepResult,
            Action onTrue,
            Action onFalse) : base(
                new HardCodedRule(stepResult),
                onTrue,
                onFalse)
        {
        }
    }
}