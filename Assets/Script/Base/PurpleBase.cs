using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBase : BaseBase
{
    [SerializeField] MiniMax miniMax = MiniMax.Maximizing;

    private void Start()
    {
        playerBase = gameObject;
        //playerBase.GetComponent<Collider>().bounds.Contains()
    }
}
