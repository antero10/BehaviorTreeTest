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

	public override void OnStart()
	{
        _agent = GetComponent<NavMeshAgent>();
        _guard = GetComponent<GuardController>();
        _placesToGo = _guard.placesToGo;
        _wayPoints = _guard.wayPoints;
    }

	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Success;
	}


}