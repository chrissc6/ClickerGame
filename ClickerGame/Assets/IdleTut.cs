using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleTut : MonoBehaviour
{
    public Text cashText;
    public double cash;

    public void Start()
    {
        cash = 0;
    }

    public void Update()
    {
        cashText.text = "Cash: $" + cash;
    }

    public void Work()
    {
        cash++;
    }







	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
