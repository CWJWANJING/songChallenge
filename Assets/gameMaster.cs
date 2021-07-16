using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{
    List<float> whichNote = new List<float>() {2,2,1,1,1,1,1,1,1,2,2,2,2,2};
    public int noteMark = 0;
    public Transform note;
    public string timerReset="y";
    public float xPos;
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

    }

    IEnumerator generateNotes(){
      yield return new WaitForSeconds(1.5f);

      if (whichNote[noteMark] == 1){
        xPos = 3.375f;
      }
      if (whichNote[noteMark] == 2){
        xPos = 1.098f;
      }
      if (whichNote[noteMark] == 3){
        xPos = -1.187f;
      }
      if (whichNote[noteMark] == 4){
        xPos = -3.458f;
      }

      noteMark += 1;
      timerReset = "y";
      note = Instantiate (note, new Vector3 (xPos,5.51f,-6.54f), note.rotation * Quaternion.Euler (0f, -80f, -90f) );

    }

}
