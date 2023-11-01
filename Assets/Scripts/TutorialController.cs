using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public GameObject[] dialogs;
    public int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        dialogs[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (index < 0)
            index = 0;
        if (index >= dialogs.Length)
            index = dialogs.Length - 1;
        
        for (int i = 0; i < dialogs.Length; i++)
        {
            if (i == index)
            {
                dialogs[i].SetActive(true);
            }
            else
            {
                dialogs[i].SetActive(false);
            }
        }
    }

    public void nextIndex()
    {
        index++;
    }
}
