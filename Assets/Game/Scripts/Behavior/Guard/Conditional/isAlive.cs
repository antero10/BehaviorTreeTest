using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class isAlive : GuardConditional
{
    public override void OnStart()
    {
        base.OnStart();
    }

    public override TaskStatus OnUpdate()
	{
        return _guard.Health > 0 ? TaskStatus.Success : TaskStatus.Failure;
	}
}