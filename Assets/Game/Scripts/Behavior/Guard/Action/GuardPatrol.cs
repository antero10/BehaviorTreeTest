using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class GuardPatrol : GuardAction
{
	public override void OnStart()
	{
        base.OnStart();
	}

    private bool arrived = false;
    private int index;
	public override TaskStatus OnUpdate()
	{
		if (!arrived)
        {
            GameObject wayPoint = _wayPoints[index];
            _agent.SetDestination(wayPoint.transform.position);
            arrived |= Vector3.Distance(_guard.transform.position, wayPoint.transform.position) < 2.5f;
        }
        else
        {
            index += 1;
            arrived = false;
        }

        if (index == _wayPoints.Count)
        {
            index = 0;
        }

        if (_placesToGo.Count > 0)
        {
            return TaskStatus.Failure;
        }
        return TaskStatus.Success;

    }



}