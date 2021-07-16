using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class string1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // void correctPitch(){
    //   GetComponent<Rigidbody>().velocity = new Vector3(1,0,0);
    //   StartCoroutine(retractCollider());
    // }

    IEnumerator retractCollider(){
      yield return new WaitForSeconds(0.5f);
      GetComponent<Rigidbody>().velocity = new Vector3(-1,0,0);
      yield return new WaitForSeconds(0.5f);
      GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
    }
}
