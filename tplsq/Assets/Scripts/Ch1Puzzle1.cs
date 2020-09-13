using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch1Puzzle1 : MonoBehaviour
{
    [SerializeField]
    private Transform[] imageMap = null;

    public static bool Success = false;

    public Ch1Puzzle1()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        Single[] deg = { 0f, 90f, 270f };
        var ran = new System.Random();
        int id;
        foreach (var image in imageMap)
        {
            id = 0;
            //id = ran.Next(3);
            image.Rotate(0f, 0f, deg[id]);
        }
        imageMap[0].Rotate(0f, 0f, deg[2]);
    }

    // Update is called once per frame
    void Update()
    {
        if (
            imageMap[0].rotation.z == 0 &&
            imageMap[1].rotation.z == 0 &&
            imageMap[2].rotation.z == 0 &&
            imageMap[3].rotation.z == 0 &&
            imageMap[4].rotation.z == 0 &&
            imageMap[5].rotation.z == 0 &&
            imageMap[6].rotation.z == 0 &&
            imageMap[7].rotation.z == 0 &&
            imageMap[8].rotation.z == 0
            )
        {
            Success = true;
        }
    }
}
