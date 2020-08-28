using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using System.Linq;
using System;

public class Grid : MonoBehaviour
{
    public GameObject nodePrefab;
    
    int[] gameBoard = new int[] { 1, 2, 3, 4, 13, 12, 11, 10, 9, 10, 11, 12, 13, 4, 3, 2, 1 };
    
    GameObject[,] Nodes = new GameObject[17, 17];

    float offsetXdistance = 3f;
    float offset = 0;
    int node;

    private void Start()
    {
        for (int row = 0; row < 17; row++)
        {
            for (node = 0; node < gameBoard[row]; node++)
            {
                Nodes[row, node] = nodePrefab;

                Nodes[row, node].GetComponent<Node>().row = row;
                Nodes[row, node].GetComponent<Node>().node = node;
                Nodes[row, node].GetComponent<Node>().nodePosition = new Vector3(node * offsetXdistance + offset, 0, row * offsetXdistance);
                Nodes[row, node].GetComponent<Node>().nodeRotation = nodePrefab.transform.rotation;
               
                Instantiate(nodePrefab, new Vector3(node * offsetXdistance + offset, 0, row * offsetXdistance), nodePrefab.transform.rotation, transform);       
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
    }
}
