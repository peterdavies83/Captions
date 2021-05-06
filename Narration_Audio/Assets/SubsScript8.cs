using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubsScript8 : MonoBehaviour
{
    public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(0);
        textBox.GetComponent<Text>().text = "And then, it blooms.";
        yield return new WaitForSeconds(2.2f);
        textBox.GetComponent<Text>().text = "Here it sits, next to the other flowers of this meadow, ready for the cycle to continue.";
        yield return new WaitForSeconds(5.6f);
        textBox.GetComponent<Text>().text = "";


    }
}
