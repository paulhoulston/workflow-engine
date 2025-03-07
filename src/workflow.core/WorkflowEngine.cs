
namespace Workflow.Core;

public class WorkflowEngine
{
    public interface IAmARule
    {
        bool Evaluate();
    }

    public WorkflowEngine()
    {

    }

    public bool Execute(IAmARule rule)
    {
        return rule.Evaluate();
    }
}