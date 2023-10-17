using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public float[,] pattern =
    {
        { 3f },
        { 5f },
        { 7f },
        { 9f },
        { 11f },
        { 13f },
        { 15f },
        { 17f },
    };

    private float[] spawnTime;

    public GameObject note;

    // Start is called before the first frame update
    void Start() { 
        spawnTime = new float[pattern.Length];
        int noteSpeed = GameObject.Find("game").GetComponent<GameController>().noteSpeed;
        // print();

        for (int i = 0; i < pattern.Length; i++)
        {
            spawnTime[i] = pattern[i, 0] - (10 / noteSpeed * 0.001f / Time.fixedTime);
            print(spawnTime[i]);
        }
    }

    // Update is called once per frame
    void Update() { }
}
