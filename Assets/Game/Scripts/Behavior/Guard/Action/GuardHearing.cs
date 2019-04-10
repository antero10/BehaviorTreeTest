using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class GuardHearing : GuardAction
{
	public override void OnStart()
	{
        base.OnStart();
	}

	public override TaskStatus OnUpdate()
	{
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                _guard.placesToGo.Add(hit.point);
                return TaskStatus.Success;
            }
        }
        return TaskStatus.Running;
    }
}