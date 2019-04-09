using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class isLookingForObject : GuardConditional
{

    public override void OnStart()
    {
        base.OnStart();
    }

    public override TaskStatus OnUpdate()
	{
        return _placesToGo.Count > 0 ? TaskStatus.Success : TaskStatus.Failure;
	}
}