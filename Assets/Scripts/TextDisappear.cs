using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisappear : MonoBehaviour {

    public float time = 10; //Seconds to read the text
    Text instruction;

    IEnumerator Start()
    {
        instruction = GetComponent<Text>();
        yield return new WaitForSeconds(time);
        instruction.fontSize = 36;
        instruction.text = "FACE";
        yield return new WaitForSeconds(2);
        instruction.text = "VELVET";
        yield return new WaitForSeconds(2);
        instruction.text = "CHURCH";
        yield return new WaitForSeconds(2);
        instruction.text = "DAISY";
        yield return new WaitForSeconds(2);
        instruction.text = "RED";
        yield return new WaitForSeconds(2);
        instruction.text = "";
    }
}
