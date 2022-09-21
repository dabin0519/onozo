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
    bool a = false, b = false, c = false, d = false, e = false, correct = false;
    bool lightA = false, lightB = false, lightC = false, lightD = false, lightE = false, lightF = false;
    [SerializeField] GameObject wow;

    public GameObject[] buttonList;
    public GameObject[] lineList;

    private void Start()
    {
        
        field.text = "";
        text.text = "비밀번호를 입력하세요";
        wow.SetActive(false);
    }
    private void Update()
    {
        
        correctA();
        if(field.text == pw){
            text.text = "열렸습니다.";
        }
        else{
            if(field.text.Length > 4){
                field.text = "";
            }
            text.text = "비밀번호를 입력하세요";
        }
    }
    public void SceneLoad(){
        SceneManager.LoadScene(sceneName);
    }
    public void ColorChange1(){
        if(!lightA)
        {
            line1.SetActive(false);
            a = false;
            lightA = true;
        }
        else
        {
            line1.SetActive(true);
            lightA = false;
        }
    }
    public void correctA(){
        if(a && b && c && d && e){
            correct = true;
        }
        if(correct == true){
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
                b = true;
                lightB = false;
                lineList[i].SetActive(false);
            }
            else{
                b = false;
                lightB = true;
                lineList[i].SetActive(true);
            }
        }
        else if(i == 3){
            if(lightC){
                c = true;
                lightC = false;
                lineList[i].SetActive(false);
            }
            else{
                c = false;
                lightC = true;
                lineList[i].SetActive(true);
            }
        }
        else if(i == 6){
            if(lightD){
                d = true;
                lightD = false;
                lineList[i].SetActive(false);
            }
            else{
                d = false;
                lightD = true;
                lineList[i].SetActive(true);
            }
        }
        else if(i == 14){
            if(lightE){
                e = true;
                lightE = false;
                lineList[i].SetActive(false);
            }
            else{
                e = false;
                lightE = true;
                lineList[i].SetActive(true);
            }
        }
        else{
            if(SetActiveOn){
                lineList[i].SetActive(false);
                SetActiveOn = false;
            }
            else {
                lineList[i].SetActive(true);
                SetActiveOn = true;
            }
        }
    }
}
