using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour {
    List<int> list = new List<int>();   // Use this for initialization
        int temp;
        int sorted;
        bool done;
    void Start()
    {   // Adds to list.
        list.Add(7);
        list.Add(1);
        list.Add(420);
        list.Add(69);
        list.Add(999);
        list.Add(666);
        list.Add(89);
        list.Add(930);
        list.Add(260);
        list.Add(975);
        list.Add(272);
        list.Add(570);

        // While the sorting isn't done the sorting loop runs.
        while (done == false)
        {   // Goes through the list.
            for (int sort = 0; sort < list.Count - 1; sort++)
            {   // Checks if the two numbers are in a sorted order.
                if (list[sort] > list[sort + 1])
                {   // If a number is in the wrong order reset the sorted int to 0.
                    sorted = 0;
                    // Switches place of the two numbers
                    temp = list[sort + 1];
                    list[sort + 1] = list[sort];
                    list[sort] = temp;
                }
                else
                {
                    // If sorted keep track of amount sorted.
                    sorted++;
                    if (sorted == list.Count)
                    {
                        // Switches the bool to show that the list is sorted.
                        done = true;
                    }
                }
            }
        }
        // Prints the result.
        for (int i = 0; i < list.Count; i++)
        {
            print(list[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
