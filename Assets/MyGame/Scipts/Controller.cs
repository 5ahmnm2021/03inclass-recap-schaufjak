

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
        private int counter = 0;
        public InputField zahl1;
        public InputField zahl2;
        public Text ergebnis;
        public Image farbfeld;

        private float zahl1Float;
        private float zahl2Float;
        


    void Start()
    {
        farbfeld.color = new Color32(102, 47, 84, 100);
    }

    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            if (counter == 0)
            {
                farbfeld.color = new Color32(255, 205, 25, 100);
            }

            if (counter == 1)
            {
                farbfeld.color = new Color32(95, 34, 0, 100);
            }

            if (counter == 2)
            {
                farbfeld.color = new Color32(207, 63, 21, 100);
            }

            if (counter == 3)
            {
                farbfeld.color = new Color32(102, 47, 84, 100);
            }

            counter++;

            if (counter == 4)
            {
                counter = 0;
            }
        }
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

    public void Addition()
    {
        try
        {
            zahl1Float = float.Parse(zahl1.text);
            zahl1.image.color = new Color32(255, 255, 255, 255);
        }
        catch (System.Exception)
        {
            zahl1.image.color = new Color32(255, 0, 0, 255);
            zahl1.text = "Zahl versuchen!";
            
        }
        try
        {
            zahl2Float = float.Parse(zahl2.text);
            zahl2.image.color = new Color32(255, 255, 255, 255);
        }
        catch (System.Exception)
        {
            zahl2.image.color = new Color32(255, 0, 0, 255);
            zahl2.text = "Zahl versuchen!";
            
        }
        ergebnis.text = (zahl1Float + zahl2Float).ToString();
    }
}
