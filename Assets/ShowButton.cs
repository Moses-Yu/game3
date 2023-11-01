using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButton : MonoBehaviour
{
    public GameObject button;
    private float timeGauge = 0;
    private bool once = false;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (timeGauge < 3f)
        {
            timeGauge += Time.deltaTime;
        }
        else if (timeGauge > 3f && !once)
        {
            once = true;
            button.SetActive(true);
        }
    }
}
