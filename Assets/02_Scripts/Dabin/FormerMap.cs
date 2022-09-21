using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormerMap : MonoBehaviour
{
    public GameObject Former;
    public GameObject[] Slots;
    public GameObject password3nd;
    public GameObject text;

    int i = 3;

    public void ButtonClickUp()
    {
        if(i < 4)
        {
            i++;
            Former.transform.position = Slots[i].transform.position;
        }
    }

    public void ButtonClickDown()
    {
        if (i > 0)
        {
            i--;
            Former.transform.position = Slots[i].transform.position;
        }
    }

    public void currectFormer()
    {
        if(i == 1)
        {
            StartCoroutine(Password());
        }
        else
        {
            StartCoroutine(Text());
        }
    }

    IEnumerator Text()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        text.SetActive(false);
    }

    IEnumerator Password()
    {
        password3nd.SetActive(true);
        yield return new WaitForSeconds(3f);
        password3nd.SetActive(false);
    }
}
