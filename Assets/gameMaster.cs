using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{
    List<float> whichNote = new List<float>() {1,3,4,2,1,2,4};
    public int noteMark = 0;
    public Transform noteObj;
    public string timerReset="y";
    public float yPos;
    public float speed = 0.7f;
    public Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (timerReset == "y"){
        StartCoroutine (generateNotes());
        timerReset = "n";
      }
      newPosition = new Vector3(-20f,yPos,-1f);
      float step =  speed * Time.deltaTime;
      noteObj.position = Vector3.Lerp(noteObj.position, newPosition, step);
      Debug.Log("move");

    }

    IEnumerator generateNotes(){
      yield return new WaitForSeconds(1);

      if (whichNote[noteMark] == 1){
        yPos = 3.5f;
      }
      if (whichNote[noteMark] == 2){
        yPos = 1.2f;
      }
      if (whichNote[noteMark] == 3){
        yPos = -1.1f;
      }
      if (whichNote[noteMark] == 4){
        yPos = -3.4f;
      }

      noteMark += 1;
      timerReset = "y";
      noteObj = Instantiate (noteObj, new Vector3 (7.25f,yPos,-1f), noteObj.rotation );
    }
}
