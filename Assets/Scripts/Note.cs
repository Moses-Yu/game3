using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("game").GetComponent<GameController>();
    }

    private bool passhitline = false;
    // Update is called once per frame
    void FixedUpdate()
    {
        // transform.localPosition = new Vector3(0, transform.localPosition.y - (GameController.noteSpeed * 0.01f), 0);



        if (!passhitline) {
            if(transform.localPosition.y < -10f){
                print("passhitline " + (transform.localPosition.y + 10));
                passhitline = true;
            }
        }
        transform.Translate(new Vector3(0, -(gameController.noteSpeed * 0.001f), 0));

        if(transform.localPosition.y < -15f){
            Destroy(gameObject);
        }
    }   
}
