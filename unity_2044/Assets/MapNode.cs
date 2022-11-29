using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapNode : MonoBehaviour
{
    [SerializeField] List<MapNode> nodes = new List<MapNode>();
    [SerializeField] NodeManager manager;
    List<Vector3Int> openVertices = new List<Vector3Int>();

    [SerializeField] GameObject instanciatedObject;
    private void Awake()
    {
        manager.Add(this);

    }

    private void Start()
    {
        Add(new Vector3Int(0, 0, 1));
        Add(new Vector3Int(0, 0, -1));
        Add(new Vector3Int(0, 1, 0));
        Add(new Vector3Int(0, -1, 0));
        Add(new Vector3Int(1, 0, 0));
        Add(new Vector3Int(-1, 0, 0));

        for (int i = 0; i < openVertices.Count; i++)
        {
            Instantiate(instanciatedObject, transform.position+openVertices[i], Quaternion.identity);
        }
    }

    private void Add(Vector3Int vI)
    {
        try
        {
            nodes.Add(manager.GetNext(this, vI));
        }
        catch (System.Exception)
        {
            openVertices.Add(vI);
        }
    }

    private void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            for(int i = 0; i < nodes.Count; i++)
            {
                Debug.DrawLine(transform.position,nodes[i].transform.position);
            }


        }


    }

}
