using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttentionNumbers : MonoBehaviour
{

    public float time = 10; //Seconds to read the text
    Text instruction;

    IEnumerator Start()
    {
        // Read list of digits
        instruction = GetComponent<Text>();
        yield return new WaitForSeconds(time);
        instruction.fontSize = 36;
        instruction.text = "2";
        yield return new WaitForSeconds(1);
        instruction.text = "1";
        yield return new WaitForSeconds(1);
        instruction.text = "8";
        yield return new WaitForSeconds(1);
        instruction.text = "5";
        yield return new WaitForSeconds(1);
        instruction.text = "4";
        yield return new WaitForSeconds(1);
        instruction.text = "";
        yield return new WaitForSeconds(10);
        instruction.fontSize = 20;
        instruction.text = "Now name the numbers that will appear in backward order";
        yield return new WaitForSeconds(10);
        instruction.fontSize = 36;
        instruction.text = "7";
        yield return new WaitForSeconds(1);
        instruction.text = "3";
        yield return new WaitForSeconds(1);
        instruction.text = "0";
        yield return new WaitForSeconds(1);
        instruction.text = "";
        yield return new WaitForSeconds(10);

        // Read list of letters
        instruction.fontSize = 20;
        instruction.text = "Letters will appear. Clap every time the letter A shows up";
        yield return new WaitForSeconds(10);
        instruction.fontSize = 36;
        instruction.text = "F";
        yield return new WaitForSeconds(1);
        instruction.text = "B";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "C";
        yield return new WaitForSeconds(1);
        instruction.text = "M";
        yield return new WaitForSeconds(1);
        instruction.text = "N";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "J";
        yield return new WaitForSeconds(1);
        instruction.text = "K";
        yield return new WaitForSeconds(1);
        instruction.text = "L";
        yield return new WaitForSeconds(1);
        instruction.text = "B";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "F";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "K";
        yield return new WaitForSeconds(1);
        instruction.text = "D";
        yield return new WaitForSeconds(1);
        instruction.text = "E";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "J";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "M";
        yield return new WaitForSeconds(1);
        instruction.text = "O";
        yield return new WaitForSeconds(1);
        instruction.text = "F";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "A";
        yield return new WaitForSeconds(1);
        instruction.text = "B";
        yield return new WaitForSeconds(1);
        instruction.text = "";
        yield return new WaitForSeconds(10);
        instruction.fontSize = 20;
        instruction.text = "Now subtract 7 from 100 5 times and say the result each time you subtract";
        yield return new WaitForSeconds(10);
        instruction.text = "You are now done with the attention test";

    }
}
