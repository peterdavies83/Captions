using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubsScript4 : MonoBehaviour
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
        textBox.GetComponent<Text>().text = "Seed dispersal is the process of moving seeds from one place to another for new plants to grow.";
        yield return new WaitForSeconds(6.3f);
        textBox.GetComponent<Text>().text = "You can see that after our bee pollinates these flowers, they can now drop their seeds.";
        yield return new WaitForSeconds(4.8f);
        textBox.GetComponent<Text>().text = "From here, they disperse, or spread around.";
        yield return new WaitForSeconds(3.3f);
        textBox.GetComponent<Text>().text = "Seeds are covered in a hard outer shell to protect them during this process.";
        yield return new WaitForSeconds(4.8f);
        textBox.GetComponent<Text>().text = "";


    }
}
