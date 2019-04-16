using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerStay(Collider other)
    {
        GuardController guard = other.gameObject.GetComponent<GuardController>();
        if (guard)
        {
            guard.Health -= 10.0f;
        }

    }

}
