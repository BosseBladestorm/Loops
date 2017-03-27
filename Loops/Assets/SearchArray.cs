using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchArray : MonoBehaviour {
    List<int> list = new List<int>();   // Use this for initialization
    public int compare;

    void Start()
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
            //Checks if the compared number is in the list
            if (list[i] == compare)
            {
                //prints the index if the number exists in the list
                print(i);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
