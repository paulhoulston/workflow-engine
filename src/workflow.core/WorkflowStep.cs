using System;

namespace Workflow.Core;

public abstract class WorkflowStep
{
    public interface IAmARule
    {
        bool Evaluate();
    }

    readonly IAmARule _rule;
    readonly Action _onTrue;
    readonly Action _onFalse;

    public WorkflowStep(
        IAmARule rule,
        Action onTrue,
        Action onFalse)
    {
        _rule = rule;
        _onTrue = onTrue;
        _onFalse = onFalse;
    }

    public void Execute()
    {
        if (_rule.Evaluate())
        {
            _onTrue();
        }
        else
        {
            _onFalse();
        }
    }
}