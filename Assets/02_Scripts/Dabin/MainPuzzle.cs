using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPuzzle : MonoBehaviour
{
    public Button[] Case;
    public bool[] caseIn;
    public GameObject post1;
    public GameObject post2;
    public GameObject post3;
    public GameObject post4;
    public GameObject post5;

    int i = 0, j = 0, k = 0;

    private void Awake()
    {
        caseIn[10] = true;
        caseIn[3] = true;
        i = Random.Range(0,2);
        caseIn[i] = true;
        j = Random.Range(4,9);
        caseIn[j] = true;
        k = Random.Range(11,13);
        caseIn[k] = true;
    }

    public void CaseLock()
    {
        if(Case[i] && caseIn[i])
        { 
            post3.SetActive(true);
        }
        else if(Case[j] && caseIn[j])
        {
            post4.SetActive(true);
        }
        else if (Case[k] && caseIn[k])
        {
            post5.SetActive(true);
        }
        else if (Case[10] && caseIn[10])
        {
            post1.SetActive(true);
        }
        else if (Case[3] && caseIn[3])
        {
            post2.SetActive(true);
        }
        else
        {
            Debug.Log("lock");
        }
    }

    public void OutCase()
    {
        post1.SetActive(false);
        post2.SetActive(false);
        post3.SetActive(false);
        post4.SetActive(false);
        post5.SetActive(false);
    }
}
