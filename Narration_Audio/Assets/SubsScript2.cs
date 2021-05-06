using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubsScript2 : MonoBehaviour
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
        textBox.GetComponent<Text>().text = "Look over here, we have a meadow, full of diverse flowers.";
        yield return new WaitForSeconds(3.9f);
        textBox.GetComponent<Text>().text = "A lot of them are fully grown and producing pollen, a yellow powder inside of flowers.";
        yield return new WaitForSeconds(5.4f);
        textBox.GetComponent<Text>().text = "In order for these flowers to spread seeds, they undergo pollenation, which is the process of moving pollen from one flower to another.";
        yield return new WaitForSeconds(8.5f);
        textBox.GetComponent<Text>().text = "Any animal that moves pollen from one plant to another is known as a pollinator, the most common of which are bees.";
        yield return new WaitForSeconds(7.3f);
        textBox.GetComponent<Text>().text = "And here is one now! Let's follow the bee along its journey!";
        yield return new WaitForSeconds(4.1f);
        textBox.GetComponent<Text>().text = "";


    }
}
