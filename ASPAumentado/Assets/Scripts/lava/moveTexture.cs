using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTexture : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    Renderer rend;

    void Start(){
        rend = GetComponent<Renderer>();
    }

    void Update(){
        float moveThis = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, moveThis));
    }
}
