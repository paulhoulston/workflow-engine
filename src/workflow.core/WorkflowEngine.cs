using System;

namespace Workflow.Core;

public class WorkflowEngine
{
    readonly WorkflowStep[] _steps;

    public WorkflowEngine(params WorkflowStep[] step)
    {
        _steps = step;
    }

    public void Execute() => _steps.ForEach(s => s.Execute());
}