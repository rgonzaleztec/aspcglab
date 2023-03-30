using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
//using Unity.VisualScripting;
using UnityEngine;

public class PinInformation : MonoBehaviour
{
    public float Offset = 0.030f;
    public GameObject _floatingTextPrefab;
    public string Text;

    // Start is called before the first frame update
    void Start()
    {
        showFloatingText(Text);

    }

    public void showFloatingText(string text)
    {
        var offset = this.transform.position + (this.transform.up * Offset); ; //+ (this.transform.right) + (this.transform.up * 0.0030f);
        var floatingText = Instantiate(_floatingTextPrefab, offset, Quaternion.identity, this.transform);
        floatingText.GetComponent<TextMeshPro>().text = text;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
