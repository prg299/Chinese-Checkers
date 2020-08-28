using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBase : MonoBehaviour
{
    [SerializeField] protected enum MiniMax { Minimizing, Maximizing }
    protected GameObject[] positiveBase;
    protected GameObject[] negativeBase;

    protected GameObject playerBase;
}
