using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        print("ты нашёл скин !");
        Destroy(gameObject);
    }
}
