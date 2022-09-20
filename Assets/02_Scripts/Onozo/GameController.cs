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
    bool a = false, b = false, c = false, d = false, e = false, correct = false;
    bool lightA = false, lightB = false, lightC = false, lightD = false, lightE = false, lightF = false;
    [SerializeField] GameObject wow;
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
            a = true;
            lightA = false;
        }
    }
    public void ColorChange2(){
        if(!lightB)
        {
            line2.SetActive(false);
            b = false;
            lightB = true;
        }
        else
        {
            line2.SetActive(true);
            b = true;
            lightB = false;
        }
    }
    public void ColorChange3(){
        if(!lightC)
        {
            line3.SetActive(false);
            c = false;
            lightC = true;
        }
        else
        {
            line3.SetActive(true);
            c = true;
            lightC = false;
        }
    }
    public void ColorChange4(){
        if(!lightD)
        {
            line4.SetActive(false);
            d = false;
            lightD = true;
        }
        else
        {
            line4.SetActive(true);
            d = true;
            lightD = false;
        }
    }
    public void ColorChange5(){
        if(!lightE)
        {
            line5.SetActive(false);
            e = false;
            lightE = true;
        }
        else
        {
            line5.SetActive(true);
            e = true;
            lightE = false;
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
}
