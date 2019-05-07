using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropDownSelect : MonoBehaviour
{
    public Dropdown Size;
    public Dropdown Speed;

    public Text sizeTxt;
    public Text speedTxt;

    static public float speed = 8f;
    static public float size = .1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (Speed.value)
        {
            case 1:
                speedTxt.text = "Slow";
                speed = 5f;
                break;
            case 2:
                speedTxt.text = "Medium";
                speed = 10f;
                break;
            case 3:
                speedTxt.text = "Fast";
                speed = 15f;
                break;
            default:
                speed = 10f;
                speedTxt.text = "Please Select";
                break;
        }


        switch (Size.value)
        {
            case 1:
                sizeTxt.text = "Small";
                size = .1f;
                break;
            case 2:
                sizeTxt.text = "Medium";
                size = .3f;
                break;
            case 3:
                sizeTxt.text = "Large";
                size = .5f;
                break;
            default:
                size = .1f;
                sizeTxt.text = "Please Select";
                break;
        }

    }
}
