using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance_Menu_Update : MonoBehaviour
{
    // visible
    [SerializeField] private Transform A, B, Target;
    
    //private 
    private KeyCode interact_key = KeyCode.E;

    void Update()
    {
        if ( (Mathf.Max(A.position.x, B.position.x) >= Target.position.x && Target.position.x >= Mathf.Min(A.position.x, B.position.x) ) &&
             (Mathf.Max(A.position.y, B.position.y) >= Target.position.y && Target.position.y >= Mathf.Min(A.position.y, B.position.y) ) &&
             (Mathf.Max(A.position.z, B.position.z) >= Target.position.z && Target.position.z >= Mathf.Min(A.position.z, B.position.z) ) && 
             Input.GetKeyUp(interact_key) )

        { Debug.Log("tag :: " + gameObject.tag + " name :: " + gameObject.name); }
    }
}