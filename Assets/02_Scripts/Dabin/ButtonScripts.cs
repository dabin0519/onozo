using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    public Text buttontext;
    public GameObject password;
    public GameObject GoPassword;
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

    public void Password()
    {
        password.SetActive(true);
        GoPassword.SetActive(false);
    }

    public void OutPassword()
    {
        password.SetActive(false);
        GoPassword.SetActive(true);
    }
}
