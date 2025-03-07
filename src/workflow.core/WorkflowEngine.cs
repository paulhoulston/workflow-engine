using System;

namespace Workflow.Core;

public class WorkflowEngine
{
    public WorkflowEngine()
    {
    }

    public void Execute(WorkflowStep step)
    {
        step.Execute();
    }
}