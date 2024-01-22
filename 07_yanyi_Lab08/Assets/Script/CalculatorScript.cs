using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CalculatorScript : MonoBehaviour
{
    public Toggle JPY;
    public float value;
    public InputField txtAmount;
    public InputField Convertedvalue;
    public Toggle USD;
    public float SGDAmount;
    public Text debuggingtext;
    public Toggle RM;
    public Toggle EUR;
    public Toggle KRW;
    public Toggle TWD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void conversion()
    {
        try
        {
            SGDAmount = float.Parse(txtAmount.text);
        }
        catch(Exception e) 
        {
            debuggingtext.text = "Key in a valid amount value";
        }
        if (USD.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 0.75f;
            Convertedvalue.text = value.ToString() + "USD";
        }
        if (JPY.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 110.42f;
            Convertedvalue.text = value.ToString() + "JPY";
        }
        if (RM.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 3.52f;
            Convertedvalue.text = value.ToString() + "RM";
        }
        if (EUR.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 0.68f;
            Convertedvalue.text = value.ToString() + "EUR";
        }
        if (KRW.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 995.72f;
            Convertedvalue.text = value.ToString() + "KRW";
        }
        if (TWD.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 23.36f;
            Convertedvalue.text = value.ToString() + "TWD";
        }

        if ((USD.GetComponent<Toggle>().isOn == true) && (JPY.GetComponent<Toggle>().isOn == true) && (RM.GetComponent<Toggle>().isOn == true) && (EUR.GetComponent<Toggle>().isOn == true) && (KRW.GetComponent<Toggle>().isOn == true) && (TWD.GetComponent<Toggle>().isOn == true))
        {
            debuggingtext.text = "Choose only one option";
            debuggingtext.GetComponent<Text>().color = Color.red;
            Convertedvalue.text = "";
        }
        else
        {
            debuggingtext.GetComponent<Text>().color = Color.black;
        }

    }
    public void Clear()
    {
        Convertedvalue.text = "";
        debuggingtext.text = "";
        txtAmount.text = "";

        JPY.GetComponent<Toggle>().isOn = false;
        USD.GetComponent<Toggle>().isOn = false;
        RM.GetComponent<Toggle>().isOn = false;
        EUR.GetComponent<Toggle>().isOn = false;
        KRW.GetComponent<Toggle>().isOn = false;
        TWD.GetComponent<Toggle>().isOn = false;
    }
}
