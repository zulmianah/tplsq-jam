using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch1Puzzle1 : MonoBehaviour
{
    [SerializeField]
    private Transform[] imageMap;

    public static bool Success;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        if (!Success)
            transform.Rotate(0f,0f,90f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
