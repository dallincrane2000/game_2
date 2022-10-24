using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.SceneManagement;

public class FieldOfView : MonoBehaviour 
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private LayerMask layerMaskPlayer;
    private Mesh mesh;
    private float fov;
    private float viewDistance;
    private Vector3 origin;
    private float rotation;
    private float startingAngle;
    public Transform point;
    private Vector3 vertex;

    private void Awake() 
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        fov = 90f;
        viewDistance = 15f;
        origin = Vector3.zero;
        //rotation = point.rotation.z;
    }

    private void LateUpdate() 
    {
        int rayCount = 100;
        float angle = startingAngle;
        float angleIncrease = fov / rayCount;

        Vector3[] vertices = new Vector3[rayCount + 1 + 1];
        Vector2[] uv = new Vector2[vertices.Length];
        int[] triangles = new int[rayCount * 3];

        vertices[0] = origin;

        int vertexIndex = 1;
        int triangleIndex = 0;
        for (int i = 0; i <= rayCount; i++)
        {
            RaycastHit2D raycastHit2D = Physics2D.Raycast(origin, UtilsClass.GetVectorFromAngle(angle), viewDistance, layerMask);
            RaycastHit2D raycastHitPlayer2D = Physics2D.Raycast(origin, UtilsClass.GetVectorFromAngle(angle), viewDistance, layerMaskPlayer);

            if (raycastHit2D.collider != null) 
            {
                vertex = raycastHit2D.point;
            } 
            else
            {
                if(raycastHitPlayer2D.collider != null)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                }
                vertex = origin + UtilsClass.GetVectorFromAngle(angle) * viewDistance;
            }
            
            vertices[vertexIndex] = vertex;

            if (i > 0) 
            {
                triangles[triangleIndex + 0] = 0;
                triangles[triangleIndex + 1] = vertexIndex - 1;
                triangles[triangleIndex + 2] = vertexIndex;

                triangleIndex += 3;
            }

            vertexIndex++;
            angle -= angleIncrease;
        }

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
        mesh.bounds = new Bounds(origin, Vector3.one * 1000f);
    }

    public void SetOrigin(Vector3 origin) 
    {
        this.origin = origin;
    }
    public void SetRotation(float rotation) 
    {
        this.rotation = rotation;
    }

    public void SetAimDirection(Vector3 aimDirection) 
    {
        startingAngle = UtilsClass.GetAngleFromVectorFloat(aimDirection) - fov / 2f;
    }

    public void SetFoV(float fov) 
    {
        this.fov = fov;
    }

    public void SetViewDistance(float viewDistance) 
    {
        this.viewDistance = viewDistance;
    }

}
