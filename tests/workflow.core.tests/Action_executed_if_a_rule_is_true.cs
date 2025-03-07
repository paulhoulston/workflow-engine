using System;
using Xunit;
using Workflow.Core;

namespace Workflow.Core.Tests;

#pragma warning disable CS0169

public class Action_executed_if_a_rule_is_true
{
    WorkflowEngine _engine;
    bool _is_true_executed;
    bool _is_false_executed;

    public Action_executed_if_a_rule_is_true()
    {
        Given_I_have_a_workflow_engine();
        When_I_add_a_rule_which_evaluates_to_true();
        Then_the_istrue_action_is_executed();
        Then_the_isfalse_action_is_not_executed();
    }

    void Given_I_have_a_workflow_engine()
    {
    }

    void When_I_add_a_rule_which_evaluates_to_true()
    {
        new WorkflowEngine(new HardCodedWorkflowStep(
            true,
            () => _is_true_executed = true,
            () => _is_false_executed = true)
        ).Execute();
    }

    [Fact]
    public void Then_the_istrue_action_is_executed()
    {
        Assert.True(_is_true_executed);
    }

    [Fact]
    public void Then_the_isfalse_action_is_not_executed()
    {
        Assert.False(_is_false_executed);
    }
}
#pragma warning restore CS0169