using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeInformationLabelCN1 : MonoBehaviour
{
    public TextMeshProUGUI textLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeLabelText(string text)
    {
        this.textLabel.text = text;
    }
}
