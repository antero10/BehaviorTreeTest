using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(List<GameObject>))]
public class GuardController : MonoBehaviour
{

    public List<Vector3> placesToGo = new List<Vector3>();
    public List<GameObject> wayPoints;

    [HideInInspector]
    public NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
