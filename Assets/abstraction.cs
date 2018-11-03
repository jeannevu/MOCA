using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abstraction : MonoBehaviour
{

    public float time = 10; //Seconds to read the text
    Text instruction;

    // Use this for initialization
    IEnumerator Start()
    {
        // Read list of digits
        instruction = GetComponent<Text>();
        yield return new WaitForSeconds(time);
        instruction.fontSize = 36;

        instruction.text = "banana/orange";
        yield return new WaitForSeconds(10);
        instruction.text = "train/bicycle";
        yield return new WaitForSeconds(10);
        instruction.text = "watch/ruler";
        yield return new WaitForSeconds(10);
    }
}
