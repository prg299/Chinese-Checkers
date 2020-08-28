using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : ScriptableObject
{
    public Vector3 nodePosition { get; set; }
    public Quaternion nodeRotation;

    public GameObject nodePrefab;

    public int row;
    public int node;
    
    bool occupied;

    private faction factionEnum = faction.open;    

    public Node(Vector3 nodePosition, Quaternion nodeRotation, GameObject nodePrefab, int row, int node)
    {
        this.nodePosition = nodePosition;
        this.nodeRotation = nodeRotation;
        this.nodePrefab = nodePrefab;
        this.row = row;
        this.node = node;
    }
}



