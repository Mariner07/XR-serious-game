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
    public void ButtonClick ()
    {
        float h = float.Parse(Height.text);
        float w = float.Parse(Width.text);
        float l = float.Parse(Length.text);
        V = h*w*l;
        Debug.Log(V);
        Cube.transform.localScale = new Vector3(l, w, h);
     }

    //public void Length_Changed(string LenText)
     //   {
      //  float temp1 = float.Parse(LenText);
       // Cube.
        //    }

}
