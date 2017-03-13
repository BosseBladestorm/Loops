using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintArray : MonoBehaviour {
    List<int> list = new List<int>();   // Use this for initialization

    void Start ()
    {   //Adds to list.
        list.Add(1);
        list.Add(7);
        list.Add(69);
        list.Add(420);
        list.Add(666);
        list.Add(999);
        //makes a loop while i is less than the list length.
        for (int i = 0; i < list.Count; i++)
        {
            print(list[i]);
        }
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
