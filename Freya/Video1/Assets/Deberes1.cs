using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Deberes1 : MonoBehaviour
{
    public float threshold = 1;
    public Transform target;
    

    void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Vector2 targetPosition = target.position;

        Vector2 meToTargetVector = targetPosition - origin;
        float meToTargetDistance = meToTargetVector.magnitude;

        if (meToTargetDistance < threshold)
            Handles.color = Color.green;
        else
            Handles.color = Color.red;

        Handles.DrawWireDisc(transform.position, new Vector3(0, 0, 1), threshold);
    }
}
