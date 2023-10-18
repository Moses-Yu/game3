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
    public GameObject game;

    // Start is called before the first frame update
    void Start() { 
        spawnTime = new float[pattern.Length];
        int noteSpeed = game.GetComponent<GameController>().noteSpeed;

        for (int i = 0; i < pattern.Length; i++)
        {
            spawnTime[i] = pattern[i, 0] - (10f / noteSpeed);
        }
        // 스폰 시간 = 화면 밖 위치할 때 3초에 히트라인에 도달하려면 속도를 고려해서 미리 스폰을 해야함
        // 얼마나 빨리 소환해야 하는가
        // 현재 속도는 초당 5 변동 될 수 있다
        // 거리 10에서 스폰을 시키면 0에 도달 하는데 까지 2초 걸린다
        // 그럼 1초에 스폰하면 된다
        

    }

    public static float timeGauge = 0f;
    private int index = 0;
    // Update is called once per 0.001f
    void FixedUpdate()
    {
        timeGauge+= Time.deltaTime;
        if(index < spawnTime.Length && timeGauge > spawnTime[index]){
            Instantiate(note, transform, false);
            index++;
            // print(timeGauge);
        }
    }
}
