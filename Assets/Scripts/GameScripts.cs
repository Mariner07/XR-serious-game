using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScripts : MonoBehaviour
{
    public InputField Height;
    public InputField Width;
    public InputField Length;
    public float V;
    public GameObject Cube;
    public GameObject Ghost;
    public Text Evaluation;
    public Slider LengthSlider;
    public Slider WidthSlider;
    public Slider HeightSlider;



    Rect rect = new Rect(0, 0, 200, 70);
    //Vector3 offset = new Vector3(-0.2f, 0f, 0.3f); // height above the target position
    //System.Random  rd = new System.Random();
    // int rand_num = rd.Next(100, 200);
    //public string ghLabel = rd.Next(6, 36).ToString();
    int ghLabel = uniqueRandomNumbers(6, 36);

   

    void OnGUI()
    {
        GUI.contentColor = Color.blue;
        GUI.skin.label.fontSize = 30;
       // Vector3 point = Camera.main.WorldToScreenPoint(Ghost.transform.position + offset);
        Vector3 point = Camera.main.WorldToScreenPoint(Ghost.transform.position);
        rect.x = point.x-20;
        rect.y = Screen.height - point.y - rect.height - 20; // bottom left corner set to the 3D point
        GUI.Label(rect, ghLabel.ToString()); // display its name, or other string

    }

        //checking if volumes are equal
        public void ButtonClick ()
    {
        //reading values from Input fields
        float h = float.Parse(Height.text);
        float w = float.Parse(Width.text);
        float l = float.Parse(Length.text);

        //checking the volume for the input values
        V = h*w*l;
        
        //comparing the volume with the required one and generating the messages
        Cube.transform.localScale = new Vector3((float)0.05*w, (float)0.05 * h, (float)0.05* l);
        if (V == ghLabel)
            {
            Evaluation.text = "V="+V.ToString() + " Right!";
            Evaluation.color = Color.green;
            Evaluation.fontSize = 20;
            Ghost.transform.rotation = Quaternion.Euler(270,18,0);
            Ghost.transform.localScale = new Vector3((float)2.2 * w, (float)2.2* l, (float)2.2 * h);
            Ghost.transform.position = Cube.transform.position;
        }
        else if (V < ghLabel)
        {
            Evaluation.text = "V=" + V.ToString() + " Too small!";
            Evaluation.color = Color.red;
            Evaluation.fontSize = 20;
            Ghost.transform.rotation = Quaternion.Euler(-90, 0, -742);
            Ghost.transform.position = new Vector3((float)-0.2-(Mathf.Max(l, w)/20), 0, (float) 0.3);
            Ghost.transform.localScale = new Vector3(5, 5, 5);
        }
        else
        {
            Evaluation.text = "V=" + V.ToString() + " Too big!";
            Evaluation.color = Color.red;
            Evaluation.fontSize = 20;
            Ghost.transform.rotation = Quaternion.Euler(-90, 0, -742);
            //Ghost.transform.position = new Vector3(-1 * Mathf.Max(l,w)-2, 0, 0);
            Ghost.transform.position = new Vector3((float)-0.2 - (Mathf.Max(l, w)/20), 0, (float)0.3);
            //Ghost.transform.localScale = new Vector3(150, 150, 150);
            Ghost.transform.localScale = new Vector3(5, 5, 5);
        }


        
    }
    //getting the infornation from Slider for the Length (in our case z axis)
    public void SliderLenght_Changed(float newValue)
    {
        Vector3 dim_l = Cube.transform.localScale;
        dim_l.z = (float)0.05 * LengthSlider.value;
        Cube.transform.localScale = dim_l;

        //showing the Slider Length value in Input Field for the Length
        Length.text = LengthSlider.value.ToString(); 
    }

    //getting the infornation from Slider for the Wdth (in our case x axis)
    public void SliderWidth_Changed(float newValue)
    {
        Vector3 dim_l = Cube.transform.localScale;
        dim_l.x = (float)0.05 * WidthSlider.value;
        Cube.transform.localScale = dim_l;
        //showing the Slider Width value in Input Field for the Width
        //Width.text = dim_l.x.ToString();
        Width.text = WidthSlider.value.ToString();
    }

    //getting the infornation from Slider for the Height (in our case y axis)
    public void SliderHeight_Changed(float newValue)
    {
        Vector3 dim_l = Cube.transform.localScale;
        dim_l.y = (float)0.05 * HeightSlider.value;
        Cube.transform.localScale = dim_l;
        //showing the Slider Height value in Input Field for the Height
        // Height.text = dim_l.y.ToString();
        Height.text = HeightSlider.value.ToString();
    }

    public void ChangeWValue()
    {
        if (WidthSlider.value != float.Parse(Width.text)) WidthSlider.value = float.Parse(Width.text);
    }

    public void ChangeLValue()
    {
        if (LengthSlider.value != float.Parse(Length.text)) LengthSlider.value = float.Parse(Length.text);
    }

    public void ChangeHValue()
    {
        if (HeightSlider.value != float.Parse(Height.text)) HeightSlider.value = float.Parse(Height.text);
    }

    private static int uniqueRandomNumbers(int min, int max)
    {
        // actual generation of random numbers
       System.Random randNum = new System.Random();

        // generate a candidate
       return randNum.Next(min, max);
    }


}
