using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notecontrol : MonoBehaviour
{
  // public GameObject correct;
  // public GameObject wrong;

  public Transform correctBurst;
  public Transform wrongBurst;

  private AndroidJavaObject jo;

  public float scorePercentage;

  // public float timeToAppear = 1f;
  // public float timeWhenDisappear;

    // Start is called before the first frame update
    void Start()
    {
      // correct.SetActive(false);
      // wrong.SetActive(false);

      //Connect with Android Studio
      AndroidJavaClass jc = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
      jo = jc.GetStatic<AndroidJavaObject> ("currentActivity");
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
      scorePercentage = 100*(gameMaster.score / gameMaster.totalScore);
      jo.Call("receiveScore",scorePercentage);

    }

    void OnTriggerEnter(Collider other){
      if (other.gameObject.name == "failcollider"){
        Debug.Log("destoyed");
        Destroy(gameObject);
        if (gameMaster.score > 0){
          gameMaster.score -= 1;
        }
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
        gameMaster.score += 10;
        // correct.SetActive(true);
        // correct.SetActive(false);
        Instantiate (correctBurst, transform.position, correctBurst.rotation);
      }
      if (other.gameObject.name == "success2"){
        Debug.Log("success2");
        Destroy(gameObject);
        gameMaster.score += 10;
        // correct.SetActive(true);
        // correct.SetActive(false);
        Instantiate (correctBurst, transform.position, correctBurst.rotation);
      }
      if (other.gameObject.name == "success3"){
        Debug.Log("success3");
        Destroy(gameObject);
        gameMaster.score += 10;
        // correct.SetActive(true);
        // correct.SetActive(false);
        Instantiate (correctBurst, transform.position, correctBurst.rotation);
      }
      if (other.gameObject.name == "success4"){
        Debug.Log("success4");
        Destroy(gameObject);
        gameMaster.score += 10;
        // correct.SetActive(true);
        // correct.SetActive(false);
        Instantiate (correctBurst, transform.position, correctBurst.rotation);
      }



    }
}
