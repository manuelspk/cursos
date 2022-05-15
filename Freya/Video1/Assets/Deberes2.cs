using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Deberes2 : MonoBehaviour
{
    [Range(0f, 1f)]
    public float threshold;
    public float productoEscalar;

    public Transform target;

    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Vector2 targetPosition = target.position;
        Vector3 thisToTargetVector = targetPosition - origin;

        productoEscalar = Vector2.Dot( transform.right, thisToTargetVector.normalized);

        Gizmos.DrawLine(transform.position, transform.position + transform.right * 100);
        Gizmos.DrawLine(transform.position, transform.position + thisToTargetVector.normalized);

        if (productoEscalar > threshold)
            Handles.color = Color.green;
        else
            Handles.color = Color.red;

        Handles.DrawWireDisc(transform.position, new Vector3(0, 0, 1), 1);
    }

}
