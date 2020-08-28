using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NodeData : MonoBehaviour
{
    public Vector3 nodePosition;
    public Quaternion nodeRotation;

    public int row;
    public int node;   

    [SerializeField] private faction factionEnum = faction.open;

    public faction factionEnumProperty
    {
        get { return factionEnum; }
        set
        {
            factionEnum = value;

            if (factionEnum == faction.purple)
            {
                PurpleBase.thisBasePurple.Add(this.gameObject);
            }
        }
    }
}

public enum faction
{
    red, blue, purple, orange, green, yellow, open
}
