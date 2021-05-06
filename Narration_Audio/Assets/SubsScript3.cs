using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubsScript3 : MonoBehaviour
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
        textBox.GetComponent<Text>().text = "Past the meadow, there are more flowers in need of pollen.";
        yield return new WaitForSeconds(3f);
        textBox.GetComponent<Text>().text = "All the pollen is sticking to the little bee. ";
        yield return new WaitForSeconds(2.9f);
        textBox.GetComponent<Text>().text = "He is flying over here to pollinate these other flowers and as he does so, some of that pollen will come off and stay in our new flowers.";
        yield return new WaitForSeconds(7.8f);
        textBox.GetComponent<Text>().text = "Once these flowers are pollinated, they produce their seeds for dispersal.";
        yield return new WaitForSeconds(4.6f);
        textBox.GetComponent<Text>().text = "";


    }
}
