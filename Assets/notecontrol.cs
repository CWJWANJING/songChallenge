using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notecontrol : MonoBehaviour
{
  // public GameObject correct;
  // public GameObject wrong;

  public Transform correctBurst;
  public Transform wrongBurst;

  // public float timeToAppear = 1f;
  // public float timeWhenDisappear;

    // Start is called before the first frame update
    void Start()
    {
      // correct.SetActive(false);
      // wrong.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      // if (Vector3.Distance(this.gameObject.transform.position, currentbar.transform.position) < 2)
      // {
      //   print(this.gameObject.transform.position);
      //   Debug.Log(Vector3.Distance(this.gameObject.transform.position, currentbar.transform.position));
      //   Debug.Log("within 1");
      //   if (Input.GetKeyDown("space")){
      //     Debug.Log("pass");
      //     Destroy(gameObject);
      //   }
      // }

    }

    void OnTriggerEnter(Collider other){
      if (other.gameObject.name == "failcollider"){
        Debug.Log("destoyed");
        Destroy(gameObject);
        // wrong.SetActive(true);
        // // https://forum.unity.com/threads/make-text-appear-then-disappear.716453/
        // timeWhenDisappear = Time.time + timeToAppear;
        // if (Time.time >= timeWhenDisappear){
        //   wrong.SetActive(false);
        // }
        Instantiate (wrongBurst, transform.position, wrongBurst.rotation);
      }
      if (other.gameObject.name == "success1"){
        Debug.Log("success1");
        Destroy(gameObject);
        // correct.SetActive(true);
        // correct.SetActive(false);
        Instantiate (correctBurst, transform.position, correctBurst.rotation);
      }
      if (other.gameObject.name == "success2"){
        Debug.Log("success2");
        Destroy(gameObject);
        // correct.SetActive(true);
        // correct.SetActive(false);
        Instantiate (correctBurst, transform.position, correctBurst.rotation);
      }
      if (other.gameObject.name == "success3"){
        Debug.Log("success3");
        Destroy(gameObject);
        // correct.SetActive(true);
        // correct.SetActive(false);
        Instantiate (correctBurst, transform.position, correctBurst.rotation);
      }
      if (other.gameObject.name == "success4"){
        Debug.Log("success4");
        Destroy(gameObject);
        // correct.SetActive(true);
        // correct.SetActive(false);
        Instantiate (correctBurst, transform.position, correctBurst.rotation);
      }



    }
}
