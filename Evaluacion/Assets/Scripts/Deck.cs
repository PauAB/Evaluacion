using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour {

    List<int> myList;

    private void Start()
    {
        myList = new List<int>();
        InitList();
        ShowList();
        Debug.Log("<---------------------------->");
        Shuffle();
        ShowList();
        Debug.Log("<---------------------------->");
        Debug.Log("First value:" + Draw());
        Debug.Log("Reinitializing list");
        InitList();
        Break();
        ShowList();
        Debug.Log("<---------------------------->");
    }

    private void InitList()
    {
        for (int i = 0; i < myList.Count; i++)
        {
            myList.Remove(i);
        }

        for (int i = 1; i <= 10; i++)
        {
            myList.Add(i);
        }

        Debug.Log("List initiated");
    }

    private void ShowList()
    {
        for (int i = 0; i < myList.Count; i++)
        {            
            Debug.Log("Value " + i + ":" + myList[i]);            
        }
    }

    private void Shuffle()
    {
        for (int i = 0; i < 100; i++)
        {
            int numRand1 = Random.Range(0, 10);
            int numRand2 = Random.Range(0, 10);

            int wildInt = myList[numRand1];
            myList[numRand1] = myList[numRand2];
            myList[numRand2] = wildInt;
        }
        
        Debug.Log("Shuffled");        
    }

    private void Break()
    {               
        int[] valuesArray = new int[myList.Count / 2];

        for (int i = 0; i < valuesArray.Length; i++)
        {
            valuesArray[i] = myList[i];
        }

        for (int i = 0; i < valuesArray.Length; i++)
        {
            myList.Remove(i);
            myList.Insert(myList.Count, valuesArray[i]);
        }

        Debug.Log("Broke");
    }

    private int Draw()
    {
        int firstValue = myList[0];                

        return firstValue;
    }
}
