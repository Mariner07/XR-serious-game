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
    public Text Evaluation;
    public Slider LengthSlider;
    public Slider WidthSlider;
    public Slider HeightSlider;
    public void ButtonClick ()
    {
        float h = float.Parse(Height.text);
        float w = float.Parse(Width.text);
        float l = float.Parse(Length.text);
        V = h*w*l;
        Debug.Log(V);
        Cube.transform.localScale = new Vector3(w, h, l);
        if (V == 36)
            {
            Evaluation.text = "V="+V.ToString() + " Right!";
            Evaluation.color = Color.green;
            Evaluation.fontSize = 20;
             }
        else if (V < 36)
        {
            Evaluation.text = "V=" + V.ToString() + " Too small!";
            Evaluation.color = Color.red;
            Evaluation.fontSize = 20;
        }
        else
        {
            Evaluation.text = "V=" + V.ToString() + " Too big!";
            Evaluation.color = Color.red;
            Evaluation.fontSize = 20;
        }


        
    }

    public void SliderLenght_Changed(float newValue)
    {
        Vector3 dim_l = Cube.transform.localScale;
        dim_l.z = LengthSlider.value;
        Cube.transform.localScale = dim_l;
        Length.text = dim_l.z.ToString(); 
    }

    public void SliderWidth_Changed(float newValue)
    {
        Vector3 dim_l = Cube.transform.localScale;
        dim_l.x = WidthSlider.value;
        Cube.transform.localScale = dim_l;
        Width.text = dim_l.x.ToString();
    }

    public void SliderHeight_Changed(float newValue)
    {
        Vector3 dim_l = Cube.transform.localScale;
        dim_l.y = HeightSlider.value;
        Cube.transform.localScale = dim_l;
        Height.text = dim_l.y.ToString();
    }


}
