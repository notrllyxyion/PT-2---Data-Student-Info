using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public InputField inputField1;
    public InputField inputField2;
    public Text resultext;


    public void CompareNumbers()
    {
        if (float.TryParse(inputField1.text, out float mumber1) && float.TryParse(inputField2.text, out float mumber2))
        {
            if (mumber1 > mumber2)
            {
                resultext.text = "First number is greaterrr";
            }
            else if (mumber1 < mumber2)
            {
                resultext.text = "Second number is greater";
            }
            else 
            {
                resultext.text = "both equal";
            }
        }
        else
        {
            resultext.text = "enter value";
        }
    }
}
