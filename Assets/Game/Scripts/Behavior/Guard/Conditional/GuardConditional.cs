using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections.Generic;

public class GuardConditional : Conditional
{
    protected GuardController _guard;
    protected List<Vector3> _placesToGo;

    public override void OnStart()
    {
        _guard = GetComponent<GuardController>();
        _placesToGo = _guard.placesToGo;
    }
    public override TaskStatus OnUpdate()
	{
		return TaskStatus.Success;
	}
}