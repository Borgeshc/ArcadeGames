using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineMazeFloorChanger : MonoBehaviour
{
    Material material;
    public Color color = Color.blue;

    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals("Player"))
        {
            if (material != null)
                material.color = color;
        }
    }
}
