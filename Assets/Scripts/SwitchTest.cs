using System;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    [Serializable]
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    
    [SerializeField] 
    private Gender myGender;
    
    private void Start()
    {
        switch (myGender)
        {
            case Gender.Male:
                Debug.Log("I am male");
                break;
            case Gender.Female:
                Debug.Log("I am female");
                break;
            case Gender.Unknown:
                Debug.Log("Gender is unknown.");
                break;
            default:
                Debug.Log("WHAT THE FUCK!");
                break;
        }
        
        string myName;

        switch (myGender)
        {
            case Gender.Male:
                myName = "Egemen";
                break;
            case Gender.Female:
                myName = "Banu";
                break;
            case Gender.Unknown:
                myName = "Hamza";
                break;
            default:
                myName = "None";
                break;
        }

        Debug.Log(myName);

        myName = myGender switch
        {
            Gender.Male => "Egemen",
            Gender.Female => "Banu",
            Gender.Unknown => "Hamza",
            _ => "None"
        };

        Debug.Log(myName);
    }
}