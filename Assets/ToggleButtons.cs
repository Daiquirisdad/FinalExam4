using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButtons : MonoBehaviour
{
    public static float timer;

    // Start is called before the first frame update
    public void oneMin()
    {
        time.timePerQuestion = 60f;
        timer = 60f;
    }


    public void thirtySec()
    {
        time.timePerQuestion = 30f;
        timer = 30f;
    }
}
