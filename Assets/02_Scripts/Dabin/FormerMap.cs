using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormerMap : MonoBehaviour
{
    public GameObject Former;
    public GameObject[] Slots;

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
            Debug.Log("Á¤´ä");
        }
    }
}
