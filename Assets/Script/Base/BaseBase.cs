using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBase : MonoBehaviour
{
    [SerializeField] protected enum MiniMax { Minimizing, Maximizing }

    protected List<Node> thisBase;
    protected List<Node> oppsiteBase;
    protected GameObject playerBase;
}
