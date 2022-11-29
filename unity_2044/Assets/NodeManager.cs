using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeManager : MonoBehaviour
{
    [SerializeField] List<MapNode> nodes = new List<MapNode>();
    Dictionary<Vector3Int,MapNode> mapNodes = new Dictionary<Vector3Int,MapNode>();

    private void Awake()
    {
        /*for (int i = 0; i < nodes.Count; i++)
        {
            mapNodes.Add(Vector3Int.RoundToInt(nodes[i].transform.position), nodes[i]);
        }*/
    }


    public void Add(MapNode a)
    {
        nodes.Add(a);
        mapNodes.Add(Vector3Int.RoundToInt(a.transform.position), a);
    }

    public MapNode GetNext(MapNode a, Vector3Int vec)
    {
        return (mapNodes[Vector3Int.RoundToInt(a.transform.position) + vec]);
    }

}
