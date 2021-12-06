using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelChange : MonoBehaviour
{
    public GameObject step1;
    public GameObject step2;
    public GameObject step3;
    public GameObject step4;
    public GameObject step5;

    // Start is called before the first frame update
    void Start()
    {
        step1.SetActive(true);
        step2.SetActive(false);
        step3.SetActive(false);
        step4.SetActive(false);
        step5.SetActive(false);

    }

    public void Step1()
    {
        step1.SetActive(true);
        step2.SetActive(false);
        step3.SetActive(false);
        step4.SetActive(false);
        step5.SetActive(false);
    }

    public void Step2()
    {
        step1.SetActive(false);
        step2.SetActive(true);
        step3.SetActive(false);
        step4.SetActive(false);
        step5.SetActive(false);
    }

    public void Step3()
    {
        step1.SetActive(false);
        step2.SetActive(false);
        step3.SetActive(true);
        step4.SetActive(false);
        step5.SetActive(false);
    }

    public void Step4()
    {
        step1.SetActive(false);
        step2.SetActive(false);
        step3.SetActive(false);
        step4.SetActive(true);
        step5.SetActive(false);
    }

    public void Step5()
    {
        step1.SetActive(false);
        step2.SetActive(false);
        step3.SetActive(false);
        step4.SetActive(false);
        step5.SetActive(true);
    }
}
