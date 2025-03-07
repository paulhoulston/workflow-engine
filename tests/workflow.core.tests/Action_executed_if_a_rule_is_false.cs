using System;
using Xunit;
using Workflow.Core;

namespace Workflow.Core.Tests
{
    public class Action_executed_if_a_rule_is_false
    {
        WorkflowEngine _engine;
        bool _result;

        public Action_executed_if_a_rule_is_false()
        {
            Given_I_have_a_workflow_engine();
            When_I_add_a_rule_which_evaluates_to_false();
            Then_then_an_action_is_not_executed();
        }

        void Given_I_have_a_workflow_engine()
        {
            _engine = new WorkflowEngine();
        }

        void When_I_add_a_rule_which_evaluates_to_false()
        {
            _result = _engine.Execute(false);
        }

        [Fact]
        public void Then_then_an_action_is_not_executed()
        {
            Assert.False(_result);
        }
    }
}