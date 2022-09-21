using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPuzzle : MonoBehaviour
{
    public GameObject[] button;
    public GameObject post1;
    public GameObject post2;
    public GameObject post3;
    public GameObject post4;
    public GameObject post5;
    public GameObject locked;
    public GameObject GoEDS;

    public bool[] caseIn;

    private void Awake()
    {
        caseIn[10] = true;
        caseIn[3] = true;
        caseIn[1] = true;
        caseIn[7] = true;
        caseIn[13] = true;
    }

    public void Case1()
    {
        post1.SetActive(true);
        GoEDS.SetActive(false);
        for (int i = 0 ; i < button.Length; i++)
        {
            button[i].SetActive(false);
        }
    }

    public void Case3()
    {
        post4.SetActive(true);
        GoEDS.SetActive(false);
        for (int i = 0; i < button.Length; i++)
        {
            button[i].SetActive(false);
        }
    }

    public void Case10()
    {
        post3.SetActive(true);
        GoEDS.SetActive(false);
        for (int i = 0; i < button.Length; i++)
        {
            button[i].SetActive(false);
        }
    }

    public void Case7()
    {
        post5.SetActive(true);
        GoEDS.SetActive(false);
        for (int i = 0; i < button.Length; i++)
        {
            button[i].SetActive(false);
        }
    }

    public void Case13()
    {
        post2.SetActive(true);
        GoEDS.SetActive(false);
        for (int i = 0; i < button.Length; i++)
        {
            button[i].SetActive(false);
        }
    }

    public void CaseLock()
    {
        StartCoroutine(lockedTxt());
    }

    public void OutCase()
    {
        GoEDS.SetActive(true);
        post1.SetActive(false);
        post2.SetActive(false);
        post3.SetActive(false);
        post4.SetActive(false);
        post5.SetActive(false);
        for (int i = 0; i < button.Length; i++)
        {
            button[i].SetActive(true);
        }
    }

    IEnumerator lockedTxt()
    {
        locked.SetActive(true);
        GoEDS.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        locked.SetActive(false);
        GoEDS.SetActive(true);
    }
}
