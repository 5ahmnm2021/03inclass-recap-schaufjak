using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{ 
    

        public InputField Zahl1;
        public InputField Zahl2;
        public Text Ergebnis;

        private float Zahl1Float;
        private float Zahl2Float;


    public void Addition()
    {
        


        try
        {
            Zahl1Float = float.Parse(Zahl1.text);
            Zahl1.image.color = new Color32(255, 255, 255, 255);
        }
        catch (System.Exception)
        {
            Zahl1.image.color = new Color32(255, 0, 0, 255);
            Zahl1.text = "Zahl versuchen!";
        }
        try
        {
            Zahl2Float = float.Parse(Zahl2.text);
            Zahl2.image.color = new Color32(255, 255, 255, 255);
        }
        catch (System.Exception)
        {
            Zahl2.image.color = new Color32(255, 0, 0, 255);
            Zahl2.text = "Zahl versuchen!";
        }
        Ergebnis.text = (Zahl1Float + Zahl2Float).ToString();

    }


    public void ChangeScene()
    {
        SceneManager.LoadScene("01ColorScene");
        
    }

    public void ChangeScene1()
    {
        SceneManager.LoadScene("02NumberScene");
       
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene("00WelcomeScene");
       
    }
}
