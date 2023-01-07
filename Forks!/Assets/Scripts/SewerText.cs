using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SewerText : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement PlayerC;
    public TextMeshProUGUI text;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerC.SewerText)
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }
    }
}