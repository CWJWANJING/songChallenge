﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class string1 : MonoBehaviour
{
  public KeyCode activate;
  public string lockInput = "n";
  public bool correctp = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(activate) && lockInput == "n"){
        lockInput = "y";
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,-2.2f);
        StartCoroutine(retractCollider());
      }
     }

    void correctPitch(){
      if (lockInput == "n"){
         lockInput = "y";
         GetComponent<Rigidbody>().velocity = new Vector3(0,0,-2.2f);
         StartCoroutine(retractCollider());
         Debug.Log("string 1");
       }
    }

    IEnumerator retractCollider(){
      yield return new WaitForSeconds(0.5f);
      GetComponent<Rigidbody>().velocity = new Vector3(0,0,2.2f);
      yield return new WaitForSeconds(0.5f);
      GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
      lockInput = "n";
    }
}
