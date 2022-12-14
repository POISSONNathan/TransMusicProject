using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticInt 
{
    public static List<int> ReturnXRandom(int x, int min, int max)
    {
        if (max < min || x > max - min)
        {
            Debug.LogError("Erreur : probleme de parametre");
            return null;
        }

        var returnedList = new List<int>();

        int generateInt = Random.Range(min, max);
        for (int i = 0; i < x; i++)
        {
            while(returnedList.Contains(generateInt))
            {
                generateInt = Random.Range(min, max);
            }
            returnedList.Add(generateInt);
        }

        return returnedList;
    }
}
