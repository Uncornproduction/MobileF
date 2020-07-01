using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveController : MonoBehaviour
{
    #region init
    //public
        [HideInInspector] public bool ClickUSEFULLY = true;
    //visible
        [SerializeField] NavMeshAgent agent = null;
    //private
        private Camera cam = null;
    private RaycastHit last_hit;
    #endregion
    private void Start() 
    {
        cam = Camera.main;
        if (!agent) { agent = gameObject.GetComponent<NavMeshAgent>(); }
    }
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && ClickUSEFULLY)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
                last_hit = hit;
            }
        }
    }
}
