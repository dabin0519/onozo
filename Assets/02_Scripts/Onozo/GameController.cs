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
    [SerializeField] SpriteRenderer line1;
    [SerializeField] SpriteRenderer line2;
    [SerializeField] SpriteRenderer line3;
    [SerializeField] SpriteRenderer line4;
    [SerializeField] SpriteRenderer line5;
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        field.text = "";
        text.text = "비밀번호를 입력하세요";
    }
    private void Update()
    {
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
        line1.GetComponent<Renderer>().material.color = Color.black;
    }
    public void ColorChange2(){
        line2.GetComponent<Renderer>().material.color = Color.black;
    }
    public void ColorChange3(){
        line3.GetComponent<Renderer>().material.color = Color.black;
    }
    public void ColorChange4(){
        line4.GetComponent<Renderer>().material.color = Color.black;
    }
    public void ColorChange5(){
        line5.GetComponent<Renderer>().material.color = Color.black;
    }
}
