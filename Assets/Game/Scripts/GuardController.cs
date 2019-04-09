using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(List<GameObject>))]
public class GuardController : MonoBehaviour
{

    public List<Vector3> placesToGo = new List<Vector3>();
    public List<GameObject> wayPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
