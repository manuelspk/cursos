using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deberes3 : MonoBehaviour
{
    public float X;
    public float Y;

    private void OnDrawGizmos()
    {
        Vector2 relativePosition = transform.right * X + transform.up * Y;

        Gizmos.DrawCube((Vector2)transform.position + relativePosition, new Vector3(1,1,1));
    }

}
