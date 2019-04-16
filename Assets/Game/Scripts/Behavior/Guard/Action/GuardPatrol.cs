using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class GuardPatrol : GuardAction
{

    private bool arrived = false;
    public override void OnStart()
	{
        base.OnStart();
	}
	public override TaskStatus OnUpdate()
	{
        base.OnUpdate();

        if (_guard.Health <= 0)
        {
            return TaskStatus.Failure;
        }
        if (_placesToGo.Count > 0)
        {
            return TaskStatus.Failure;
        }
        if (_wayPointIndex.Value >= _wayPoints.Count)
        {
            _behaviorTree.SetVariable("wayPointIndex", (SharedInt)0);
            _wayPointIndex = 0;
        }
        GameObject wayPoint = _wayPoints.Count > 0 && _wayPointIndex.Value <= _wayPoints.Count ? _wayPoints[_wayPointIndex.Value]: null;
        if (wayPoint)
        {
            if (Vector3.Distance(_guard.transform.position, wayPoint.transform.position) <= maxDistance)
            {
                arrived = true;
                _behaviorTree.SetVariable("isAtWayPoint", (SharedBool)true);
                return TaskStatus.Success;
            }

            if (_agent.velocity == Vector3.zero)
            {
                _agent.ResetPath();
                _agent.SetDestination(wayPoint.transform.position);

                arrived = false;
            }

        }

      

        return TaskStatus.Running;

    }



}