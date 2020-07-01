using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
public class CameraController : MonoBehaviour
{
    #region init
    //public
    //visible
        [Header("Main options")] [Space(-5)]
        [SerializeField] bool showMain = false; 
        [ShowIf("showMain")] [SerializeField] Transform target = null;
        [ShowIf("showMain")] [SerializeField] Vector3 offset;


        [Header("Smooth options")] [Space(-5)]
        [SerializeField] bool showSmooth = false;
        [ShowIf("showSmooth")] [SerializeField] float smoothness = 1f;


        [Header("Zoom options")] [Space(-5)]
        [SerializeField] bool showZoom = false; 
        [ShowIf("showZoom")] [SerializeField] bool useZoom = true;
        [ShowIf("showZoom")] [SerializeField] float zoomSpeed = 5f;
        [ShowIf("showZoom")] [SerializeField] float minZoom = 0, maxZoom = 10;


        [Header("Orbit rotation options")] [Space(-5)]
        [SerializeField] bool showOrbitRotation = false;
        [ShowIf("showOrbitRotation")] [SerializeField] bool useOrbit = true;
        [ShowIf("showOrbitRotation")] [SerializeField] float rotationSpeed = 10f;
    //private
        private float currenrentZoom = 0, currenrentRotation = 0;
        private Vector3 _offset;
    #endregion
    void FixedUpdate() 
    {
        currenrentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime;
        currenrentZoom = Mathf.Clamp(currenrentZoom, minZoom, maxZoom);  

        Vector3 startPosition = transform.position;
        Vector3 endPosition;
        if (useZoom) { endPosition = target.position + offset * currenrentZoom; } 
        else { endPosition = target.position + offset; } 
        transform.position = Vector3.Lerp(transform.position, endPosition, smoothness);
        
        if (Input.GetMouseButton(1) && useOrbit) 
        { 
            Quaternion turnAxis = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime, Vector3.up);
            offset = turnAxis * offset;
        }
        
    }

    void Update() 
    {
        transform.LookAt(target.position);
    }
}
