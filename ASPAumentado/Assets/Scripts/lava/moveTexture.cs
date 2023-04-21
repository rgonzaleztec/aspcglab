using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTexture : MonoBehaviour
{

    public float scrollSpeedX = 0.1f;
    public float scrollSpeedY = 0.1f;
    public float scrollSpeedZ = 0.1f;
    public int textureIndex = 0;
    Renderer rend;

    void Start(){
        rend = GetComponent<Renderer>();
    }

    void Update(){

        float time= Time.time;
        float moveThisY = time * scrollSpeedY;
        float moveThisX = time * scrollSpeedX;
        float moveThisZ = time * scrollSpeedZ;
        rend.materials[textureIndex].SetTextureOffset("_MainTex", new Vector3(moveThisX, moveThisY,moveThisZ));
    }
}
