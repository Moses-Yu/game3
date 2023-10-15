using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyMethods
{
    public class SceneController
    {
        public void ChangeScene(string sceneTo)
        {
            // sound effect
            // delay
            // SceneChange effect
            SceneManager.LoadScene(sceneTo);
        }
    }
}
