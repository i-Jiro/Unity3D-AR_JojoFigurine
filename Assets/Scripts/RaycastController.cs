using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    [SerializeField] private float _rayLength = 10f;

    void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(transform.position,transform.forward,Color.red);
        _lineRenderer.SetPosition(0, transform.position);
        if(Physics.Raycast(ray, out hit, _rayLength))
        {
            _lineRenderer.SetPosition(1, hit.point);
        }
        else
        {
            _lineRenderer.SetPosition(1,transform.position + (transform.forward * _rayLength));
        }
    }
}
