using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch1Puzzle1Manager : MonoBehaviour
{
    public void OnMouseDown()
    {
        if (!Ch1Puzzle1.Success)
            transform.Rotate(0f, 0f, 90f);
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
