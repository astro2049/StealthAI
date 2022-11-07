using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class LaserSight : MonoBehaviour
{
    public float fov = 120f;
    public int sliceCount = 10;
    public float viewDistance = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        float angleIncrease = fov / sliceCount;
        float angle = 0;
        Vector3 origin = Vector3.zero;
        Vector3[] vertices = new Vector3[sliceCount + 2];
        Vector2[] uv = new Vector2[vertices.Length];
        int[] indices = new int[sliceCount * 3];
        
        vertices[0] = Vector3.zero;
        int triangleIndex = 0;
        for (int i = 0; i <= sliceCount; i++)
        {
            Vector3 vertex = origin + RotateVector(angle) * viewDistance;
            vertices[i + 1] = vertex;
            angle += angleIncrease;

            if (i >= 1)
            {
                indices[triangleIndex++] = 0;
                indices[triangleIndex++] = i - 1;
                indices[triangleIndex++] = i;
            }
        }

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = indices;
    }

    private Vector3 RotateVector(float angle)
    {
        float angleRad = angle * (Mathf.PI / 180f);
        return new Vector3(Mathf.Cos(angleRad) - Mathf.Sin(angleRad), -0.5f, Mathf.Sin(angleRad) + Mathf.Cos(angleRad));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
