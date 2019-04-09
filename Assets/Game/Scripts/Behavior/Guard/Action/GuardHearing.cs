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
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                Debug.Log("I got you");
                _placesToGo.Add(hitInfo.point);
            }
        }
        return TaskStatus.Success;
    }
}