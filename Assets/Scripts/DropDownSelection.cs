using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSelection : MonoBehaviour
{
    // this script is attached to the manager, but could be attached to any gameobject that has an update method.
    public Dropdown WordColorDropDown;
    public Text MyChoice;

    // Update is called once per frame
    public void ShowChoice()
    {
        switch (WordColorDropDown.value)
        {
            case 1:
                MyChoice.text = "Blue";
                break;
            case 2:
                MyChoice.text = "Yellow";
                break;
            case 3:
                MyChoice.text = "Orange";
                break;
            default:
                MyChoice.text = "Please Select";
                break;
        }
    }
}