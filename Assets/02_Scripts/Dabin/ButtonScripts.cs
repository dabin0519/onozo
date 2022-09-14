using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    public Text buttontext;
    private int num;

    public void ButtonUp()
    {
        num++;
        if (num >= 10)
        {
            num = 0;
        }
        string numstring = num.ToString();
        buttontext.text = numstring;
    }
}
