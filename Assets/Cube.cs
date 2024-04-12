using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        renderer.material.color = Color.blue;
    }

    void OnCollisionExit()
    {
        renderer.material.color = new Color(255 / 255f, 163 / 255f, 186 / 255f);
    }
}
