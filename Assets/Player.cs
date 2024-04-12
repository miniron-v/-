using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.01f, 0, 0);
    }
}
