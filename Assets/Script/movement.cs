using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float playerSpeed = 12f;

    private void Start()
    {
    }

    void Update()
    {
        if(Input.GetButton("Fire1")){
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
    }
}
