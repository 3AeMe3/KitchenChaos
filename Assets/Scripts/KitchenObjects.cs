using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class KitchenObjects : MonoBehaviour
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;

    private ClearCounter clearCounter;

    public KitchenObjectsSO GetKitchenObjectsSO()
    {
        return kitchenObjectsSO;
    }

   //setear el clearcounter desde otro lado 

    public void SetClearCounter(ClearCounter clearCounter)
    {
        if(this.clearCounter != null)
        {
            this.clearCounter.ClearKitchenObjects(); 
        }
        this.clearCounter = clearCounter;

        if (clearCounter.HasKitchenObjects())
        {
            Debug.LogError("Counter already has a kitchenObject!");
        }

        clearCounter.SetKitchenObjects(this);
        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public ClearCounter GetClearCounter()
    {
        return clearCounter;
    }
    //devolver la variable clearCounter

}
