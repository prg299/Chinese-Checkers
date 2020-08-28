using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBase : BaseBase
{
    public static List<GameObject> thisBasePurple = new List<GameObject>();

    [SerializeField] MiniMax miniMax = MiniMax.Maximizing;
    [SerializeField] List<Node> gameObjects;

    private void Awake()
    {
        thisBase = new List<Node>();
        playerBase = gameObject;
    }

    private void GetBaseNodes(Node[,] nodes)
    {
        //foreach (Node node in nodes)
        //{          
        //    if (node != null)
        //    {                
        //        thisBase.Add(node);
        //    }
        //}
        gameObjects = thisBase;
    }

    private void OnEnable()
    {
        Grid.AssignBaseEvent += GetBaseNodes;
    }

    private void OnDisable()
    {
        Grid.AssignBaseEvent -= GetBaseNodes;
    }
}
