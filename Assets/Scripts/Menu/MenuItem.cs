using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuItem : MonoBehaviour
{
    public bool selected = false;
    public string sceneTo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(selected){
            gameObject.GetComponent<TextMeshProUGUI>().fontSize = 90f;
        }
        else{
            gameObject.GetComponent<TextMeshProUGUI>().fontSize = 68.2f;
        }
    }
}
