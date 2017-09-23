using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealMaterialOnContact : MonoBehaviour
{
    Renderer invisibleRenderer;

    // Use this for initialization
    void Start()
    {
        invisibleRenderer = GetComponent<MeshRenderer>();
        invisibleRenderer.enabled = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            invisibleRenderer.enabled = true;
        }
    }
}