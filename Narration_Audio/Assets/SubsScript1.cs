using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubsScript1 : MonoBehaviour
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
        textBox.GetComponent<Text>().text = "All plants begin as a seed.";
        yield return new WaitForSeconds(2.9f);
        textBox.GetComponent<Text>().text = "A seed is the part of a plant that can grow to become a new plant.";
        yield return new WaitForSeconds(3.8f);
        textBox.GetComponent<Text>().text = "Like us humans, plants go through a life cycle, changing and growing as they get older.";
        yield return new WaitForSeconds(5.2f);
        textBox.GetComponent<Text>().text = "In order for these seeds to spread and new plants to grow, they depend on the forces of nature to move them around and for pollenation.";
        yield return new WaitForSeconds(8f);
        textBox.GetComponent<Text>().text = "";


    }
}
