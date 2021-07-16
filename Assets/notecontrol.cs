using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notecontrol : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
      if (other.gameObject.name == "failcollider"){
        Debug.Log("destoyed");
        Destroy(gameObject);
      }
      if (other.gameObject.name == "success1"){
        Debug.Log("success");
        Destroy(gameObject);
      }
    }
}
