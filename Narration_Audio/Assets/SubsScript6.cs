using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubsScript6 : MonoBehaviour
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
        textBox.GetComponent<Text>().text = "It seems like our seed has settled next to all these other new plants.";
        yield return new WaitForSeconds(4.1f);
        textBox.GetComponent<Text>().text = "It will germinate and begin to grow here on the soil.";
        yield return new WaitForSeconds(3.2f);
        textBox.GetComponent<Text>().text = "Next to the river it shall get plenty of water, and in the middle of this meadow it will get plenty of sunlight.";
        yield return new WaitForSeconds(7.2f);
        textBox.GetComponent<Text>().text = "";


    }
}
