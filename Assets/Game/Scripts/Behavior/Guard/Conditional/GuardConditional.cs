using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections.Generic;

public class GuardConditional : Conditional
{
    protected GuardController _guard;
    protected List<Vector3> _placesToGo;
    private BehaviorTree _behaviorTree;
    protected SharedBool _isAtWayPoint;
    protected SharedInt _wayPointIndex;

    public override void OnStart()
    {
        _guard = GetComponent<GuardController>();
        _behaviorTree = GetComponent<BehaviorTree>();

        _isAtWayPoint = (SharedBool) _behaviorTree.GetVariable("isAtWayPoint");
        _wayPointIndex = (SharedInt)_behaviorTree.GetVariable("wayPointIndex");
        _placesToGo = _guard.placesToGo;
    }
    public override TaskStatus OnUpdate()
	{
        _isAtWayPoint = (SharedBool)_behaviorTree.GetVariable("isAtWayPoint");
        _wayPointIndex = (SharedInt)_behaviorTree.GetVariable("wayPointIndex");
        _placesToGo = _guard.placesToGo;
        return TaskStatus.Success;
	}
}