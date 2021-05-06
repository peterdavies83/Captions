using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubsScript7 : MonoBehaviour
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
        textBox.GetComponent<Text>().text = "Plants need time to grow from little seeds.";
        yield return new WaitForSeconds(3.2f);
        textBox.GetComponent<Text>().text = "Let's speed this one along though, so you can see it.";
        yield return new WaitForSeconds(3.5f);
        textBox.GetComponent<Text>().text = "First, it sprouts roots that will absorb water from the ground.";
        yield return new WaitForSeconds(4.3f);
        textBox.GetComponent<Text>().text = "From there it grows its stem to help support it.";
        yield return new WaitForSeconds(3.4f);
        textBox.GetComponent<Text>().text = "Off of the stem will grow little leaves to collect sunlight.";
        yield return new WaitForSeconds(4.2f);
        textBox.GetComponent<Text>().text = "";


    }
}
