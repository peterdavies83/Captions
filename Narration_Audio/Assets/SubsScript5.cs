using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubsScript5 : MonoBehaviour
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
        textBox.GetComponent<Text>().text = "With our seeds lying on the ground here, they are scattered by different factors that will move them to where they are eventually planted.";
        yield return new WaitForSeconds(7.8f);
        textBox.GetComponent<Text>().text = "Animals, wind, and water all pick up and carry the little seeds to their new destinations.";
        yield return new WaitForSeconds(5.8f);
        textBox.GetComponent<Text>().text = "Like this seed here, it's started moving!";
        yield return new WaitForSeconds(3.1f);
        textBox.GetComponent<Text>().text = "It looks like it was picked up by the wind. Where is it being taken?";
        yield return new WaitForSeconds(4.3f);
        textBox.GetComponent<Text>().text = "";


    }
}
