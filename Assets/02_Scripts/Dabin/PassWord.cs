using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PassWord : MonoBehaviour
{
    public Text passWord;
    public Text passWord1;
    public Text passWord2;
    public GameObject wrong;

    public string p1;
    public string p2;
    public string p3;

    private bool cur;

    public void Currect()
    {
        cur = passWord.text == p1 ? passWord1.text == p2? passWord2.text == p3? true : false : false : false;

        if(cur)
        {
            SceneManager.LoadScene("End");
        }
        else
        {
            StartCoroutine(Wrong());
        }
    }

    IEnumerator Wrong()
    {
        wrong.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        wrong.SetActive(false);
    }
}
