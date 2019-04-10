using BehaviorDesigner.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BehaviorTree))]
public class ClickToMove : MonoBehaviour
{

    private GuardController guardController;

    void Start()
    {
        guardController = GetComponent<GuardController>();
       
    }

    void Update()
    {
       
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 100f))
            {
                if (!guardController.placesToGo.Contains(hit.point))
                {
                    guardController.placesToGo.Add(hit.point);
                }
            }
        }
    }
}
