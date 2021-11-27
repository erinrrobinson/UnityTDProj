using UnityEngine;
using System.Collections;

public class OSCmove : MonoBehaviour {
    
   	public OSC osc;


	// Use this for initialization
	void Start () {
       osc.SetAddressHandler( "/3/xyM_l" , OnReceiveXYZ );
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnReceiveXYZ(OscMessage message){
		float x = message.GetFloat(0);
        float y = message.GetFloat(1);

        x = x * 100;
        y = y * 100;

        Debug.Log("x position" + x);

		transform.position = new Vector3(x,y,0f);
	}


}
