using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world 1!");
        Debug.Log("Hello world 2!");
        Debug.LogWarning("Hello world 3!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("Hello world - update!");
    }
}
