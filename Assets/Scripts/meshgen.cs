using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class meshgen : MonoBehaviour
{
    [SerializeField]
    public int width = 1;
    int height = 1;
    [SerializeField]
    float x,y;
    
    void Start()
    {
        initprogen();
    }

    void initprogen()
    {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        MeshFilter meshFilter = gameObject.GetComponent<MeshFilter>();
        Mesh mesh=new Mesh();
        List<Vector3> vertices = new List<Vector3>();
        for(int i=0;i<width;i++)
        {
            vertices.Add(new Vector3(i, 0, 0));
            vertices.Add(new Vector3(1+i, 0, 0));
            vertices.Add(new Vector3(i,1,0));
            vertices.Add(new Vector3(1+i,1,0));
        }
        mesh.vertices = vertices.ToArray();

        List<int> tris = new List<int>();
        for(int i=0;i<(width-1)*4+1;i++)
        {
            tris.Add(i);
            tris.Add(2+i);
            tris.Add(1+i);
            tris.Add(2+i);
            tris.Add(3+i);
            tris.Add(1+i);
        }
        mesh.triangles=tris.ToArray();

        List<Vector2> uv=new List<Vector2>();
        for(int i=0;i<width;i++)
        {
            uv.Add(new Vector3(i, 0, 0));
            uv.Add(new Vector3(1+i, 0, 0));
            uv.Add(new Vector3(i, height, 0));
            uv.Add(new Vector3(1+i,height, 0));
        }
        mesh.uv=uv.ToArray();
        meshFilter.sharedMesh=mesh;
        meshFilter.sharedMesh.RecalculateNormals();

        List<Vector2> ed=new List<Vector2>();
        for(int i=2;i+1<width*4;i+=4)
        {
            ed.Add(vertices[i]);
            ed.Add(vertices[i+1]);
        }
        GetComponent<EdgeCollider2D>().SetPoints(ed);
    }

    public void progen()
    {
        width+=1;
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        MeshFilter meshFilter = gameObject.GetComponent<MeshFilter>();
        Mesh mesh=new Mesh();
        List<Vector3> vertices = new List<Vector3>();
        for(int i=0;i<width;i++)
        {
            vertices.Add(new Vector3(i, 0, 0));
            vertices.Add(new Vector3(1+i, 0, 0));
            vertices.Add(new Vector3(i,1,0));
            vertices.Add(new Vector3(1+i,1,0));
        }
        mesh.vertices = vertices.ToArray();

        List<int> tris = new List<int>();
        for(int i=0;i<(width-1)*4+1;i++)
        {
            tris.Add(i);
            tris.Add(2+i);
            tris.Add(1+i);
            tris.Add(2+i);
            tris.Add(3+i);
            tris.Add(1+i);
        }
        mesh.triangles=tris.ToArray();

        List<Vector2> uv=new List<Vector2>();
        for(int i=0;i<width;i++)
        {
            uv.Add(new Vector3(i, 0, 0));
            uv.Add(new Vector3(1+i, 0, 0));
            uv.Add(new Vector3(i, height, 0));
            uv.Add(new Vector3(1+i,height, 0));
        }
        mesh.uv=uv.ToArray();
        meshFilter.sharedMesh=mesh;
        meshFilter.sharedMesh.RecalculateNormals();

        List<Vector2> ed=new List<Vector2>();
        for(int i=2;i+1<width*4;i+=4)
        {
            ed.Add(vertices[i]);
            ed.Add(vertices[i+1]);
        }
        GetComponent<EdgeCollider2D>().SetPoints(ed);
    }
}