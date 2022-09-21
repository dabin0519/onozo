using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject que1B;
    public GameObject que2B;
    public GameObject que3B;
    public GameObject sceneLoader;

    public void Que1()
    {
        question1.SetActive(true);
        que1B.SetActive(false);
        sceneLoader.SetActive(false);
    }

    public void Que2()
    {
        question2.SetActive(true);
        que2B.SetActive(false);
        sceneLoader.SetActive(false);
    }

    public void Que3() 
    {
        question3.SetActive(true);
        que3B.SetActive(true);
        sceneLoader.SetActive(false);
    }

    public void OutQue()
    {
        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        que1B.SetActive(true);
        que2B.SetActive(true);
        que3B.SetActive(true);
        sceneLoader.SetActive(true);
    }
}
