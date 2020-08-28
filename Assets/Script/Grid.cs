using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using System.Linq;
using System;

[ExecuteInEditMode]
public class Grid : MonoBehaviour
{
    public delegate void AssignBases(Node[,] nodes);
    public static event AssignBases AssignBaseEvent;

    public GameObject nodePrefab;

    int[] gameBoard = new int[] { 1, 2, 3, 4, 13, 12, 11, 10, 9, 10, 11, 12, 13, 4, 3, 2, 1 };

    Node[,] Nodes = new Node[17, 17];

    float offsetXdistance = 3f;
    float offset = 0;
    int node;

    private void Start()
    {
        for (int row = 0; row < 17; row++)
        {
            for (node = 0; node < gameBoard[row]; node++)
            {
                nodePrefab.GetComponent<NodeData>().row = row;
                nodePrefab.GetComponent<NodeData>().node = node;
                nodePrefab.GetComponent<NodeData>().nodeRotation = nodePrefab.transform.rotation;
                nodePrefab.GetComponent<NodeData>().nodePosition = new Vector3(node * offsetXdistance + offset, 0, row * offsetXdistance);

                //Nodes[row, node].factionEnum = nodePrefab.GetComponent<NodeData>().factionEnum;

                Nodes[row, node] = new Node(new Vector3(node * offsetXdistance + offset, 0, row * offsetXdistance), nodePrefab.transform.rotation, nodePrefab, row, node);

                Instantiate(Nodes[row, node].nodePrefab, Nodes[row, node].nodePosition, Nodes[row, node].nodeRotation, transform);
            }

            if (row < 3)
            {
                offset -= offsetXdistance / 2;
            }
            else if (row == 3)
            {
                offset -= 13.5f;
            }
            else if (row > 7 && row < 12)
            {
                offset -= offsetXdistance / 2;
            }
            else if (row == 12)
            {
                offset += 13.5f;
            }
            else
            {
                offset += offsetXdistance / 2;
            }
        }

        AssignBaseEvent?.Invoke(Nodes);
    }
}
