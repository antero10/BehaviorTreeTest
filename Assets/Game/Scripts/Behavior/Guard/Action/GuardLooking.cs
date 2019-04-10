using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

public class GuardLooking : GuardAction
{

    private bool onMyWay = false;
    private List<Vector3> orderList;

    public override void OnStart()
	{
        base.OnStart();
        OrderList();
    }

	public override TaskStatus OnUpdate()
	{
        if (_guard.placesToGo.Count > 0)
        {
            if (!onMyWay)
            {
                foreach (Vector3 position in orderList)
                {
                    StartCoroutine(goToPoint(position));

                }
            }
            
        }

        if (_guard.placesToGo.Count == 0 )
        {
            Debug.Log("I'm done i go back go my work");
            return TaskStatus.Success;
        }
		return TaskStatus.Running;
	}

    private IEnumerator goToPoint(Vector3 point)
    {
        _agent.SetDestination(point);
        onMyWay = true;
        yield return new WaitUntil(() => Vector3.Distance(_guard.transform.position, point) <= 5.0f);
        _guard.placesToGo.Remove(point);
        onMyWay = false;
        OrderList();


    }

    private void OrderList()
    {
        orderList = _guard.placesToGo.OrderBy(
            x => Vector2.Distance(this.transform.position, x)
        ).ToList();
    }
}