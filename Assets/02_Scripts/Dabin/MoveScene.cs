using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour
{
    public GameObject EDS;
    public GameObject MGS;

    public void GoEDS()
    {
        EDS.SetActive(true);
        MGS.SetActive(false);
    }

    public void GoMGS()
    {
        EDS.SetActive(false);
        MGS.SetActive(true);
    }
}
