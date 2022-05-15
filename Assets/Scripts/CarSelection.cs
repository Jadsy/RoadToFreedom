using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{

    public Button PreviousButton;
    public Button NextButton;
    private int currentCar;
    public static int indexor;
    private void Awake(){
        SelectCar(0);
    }

    private void SelectCar(int _index){
        PreviousButton.interactable = (_index != 0);
        NextButton.interactable = (_index != transform.childCount -1);
        for (int i = 0;i < transform.childCount; i++){
            transform.GetChild(i).gameObject.SetActive(i == _index);
            indexor = _index; 
        }
    }

    public void ChangeCar(int _change){
        currentCar += _change;
        SelectCar(currentCar);
    }
    
}
