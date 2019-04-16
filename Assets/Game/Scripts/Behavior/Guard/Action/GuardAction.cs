using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;
using System.Collections.Generic;

public class GuardAction : Action
{
    protected NavMeshAgent _agent;
    protected GuardController _guard;
    protected List<Vector3> _placesToGo;
    protected List<GameObject> _wayPoints;
    protected BehaviorTree _behaviorTree;
    protected SharedBool _isAtWayPoint;
    protected SharedInt _wayPointIndex;
    protected readonly float maxDistance = 2.3f;

    public override void OnStart()
	{
        _agent = GetComponent<NavMeshAgent>();
        _guard = GetComponent<GuardController>();
        _behaviorTree = GetComponent<BehaviorTree>();

        _placesToGo = _guard.placesToGo;
        _wayPoints = _guard.wayPoints;
        _isAtWayPoint = (SharedBool)_behaviorTree.GetVariable("isAtWayPoint");
        _wayPointIndex = (SharedInt)_behaviorTree.GetVariable("wayPointIndex");
    }

	public override TaskStatus OnUpdate()
	{
        return TaskStatus.Success;
	}


}