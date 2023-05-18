using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoChange : MonoBehaviour
{

    float seconds;
    ArrayList listSeconds = new ArrayList();
    ArrayList materials = new ArrayList();

    Material meterial1;
    Material meterial2;
    Material meterial3;
    Material meterial4;

    // Start is called before the first frame update
    void Start()
    {
        listSeconds.Add(4f);
        listSeconds.Add(4f);
        listSeconds.Add(4.5f);
        listSeconds.Add(4f);
        materials.Add(meterial1);
        materials.Add(meterial2);
        materials.Add(meterial3);
        materials.Add(meterial4);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator nextImage(){
        yield return new WaitForSeconds(seconds);
    }
}
