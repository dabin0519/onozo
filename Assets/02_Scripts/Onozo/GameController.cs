using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] InputField field;
    [SerializeField] Text text;
    [SerializeField] string pw = "1234";
    [SerializeField] string sceneName;
    [SerializeField] GameObject line1;
    [SerializeField] GameObject line2;
    [SerializeField] GameObject line3;
    [SerializeField] GameObject line4;
    [SerializeField] GameObject line5;
    bool SetActiveOn;
    public bool a, b, c , d , e ,correct = false,f = true;
    bool lightA = false, lightB = false, lightC = false, lightD = false, lightE = false, lightF = false;
    [SerializeField] GameObject wow;

    public GameObject[] buttonList;
    public GameObject[] lineList;
    public GameObject Password1st;

    private void Start()
    {
        
        field.text = "";
        text.text = "가열된 물질에서 빛이 방출되어 관찰되는 스펙트럼을 방출스펙트럼이라고 한다.";
        wow.SetActive(false);
    }
    private void Update()
    {
        
        correctA();
        if(field.text == pw){
            Password1st.SetActive(true);
        }
        else{
            if(field.text.Length > 6){
                field.text = "";
            }
            text.text = "가열된 물질에서 빛이 방출되어 관찰되는 \n 스펙트럼을 방출스펙트럼이라고 한다.";
        }
    }

    #region ===================================================================================================

    public void SceneLoad(){
        SceneManager.LoadScene(sceneName);
    }

    public void correctA(){
        if(a && b && c && d && e && f){
            wow.SetActive(true);
        }
    }

    public void Button2(int i){

        if(i == 0){
            if(!lightA){
                lineList[i].SetActive(false);
                a = false;
                lightA = true;
            }
            else{
                lineList[i].SetActive(true);
                a = true;
                lightA = false;
            }
        }
        else if(i == 1){
            if(lightB){
                b = false;
                lightB = false;
                lineList[i].SetActive(false);
            }
            else{
                b = true;
                lightB = true;
                lineList[i].SetActive(true);
            }
        }
        else if(i == 3){
            if(lightC){
                c = false;
                lightC = false;
                lineList[i].SetActive(false);
            }
            else{
                c = true;
                lightC = true;
                lineList[i].SetActive(true);
            }
        }
        else if(i == 6){
            if(lightD){
                d = false;
                lightD = false;
                lineList[i].SetActive(false);
            }
            else{
                d = true;
                lightD = true;
                lineList[i].SetActive(true);
            }
        }
        else if(i == 14){
            if(lightE){
                e = false;
                lightE = false;
                lineList[i].SetActive(false);
            }
            else{
                e = true;
                lightE = true;
                lineList[i].SetActive(true);
            }
        }
        else{
            if(SetActiveOn){
                lineList[i].SetActive(false);
                f = true;
                SetActiveOn = false;
            }
            else {
                lineList[i].SetActive(true);
                f = false;
                SetActiveOn = true;
            }
        }

        #endregion
    }
}
