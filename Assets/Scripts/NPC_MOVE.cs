using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_MOVE : MonoBehaviour {

    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

	// Use this for initialization
	void Start () {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
	}

    private void Update()
    {
        if (_navMeshAgent == null)
        {
            Debug.Log("The nav mesh agent component is not attached to " + gameObject.name);
        }
        else
        {
            SetDistanation();
        }
    }

    private void SetDistanation()
    {
        if(_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
}
