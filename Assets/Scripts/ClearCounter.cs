using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;
    [SerializeField] private ClearCounter secondClearCounter;
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private bool testing;
    private KitchenObjects kitchenObjects;


    private void Update()
    {
        if(testing && Input.GetKeyDown(KeyCode.T))
        {
            if(kitchenObjects != null)
            {
                kitchenObjects.SetClearCounter(secondClearCounter);
  
            }
        }
    }
    public void Interact()
    {
        //no hay nada en la caja
        if(kitchenObjects == null)
        {
            Transform kitchenObjectSoTransform = Instantiate(kitchenObjectsSO.prefab, counterTopPoint);
            kitchenObjectSoTransform.GetComponent<KitchenObjects>().SetClearCounter(this);
 

        }
        else
        {
            Debug.Log(kitchenObjects.GetClearCounter());
        }
    }
    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void SetKitchenObjects(KitchenObjects kitchenObjects)
    {
        this.kitchenObjects = kitchenObjects;
    }
    public KitchenObjects GetKitchenObjects()
    {
        return kitchenObjects;
    }

    public void ClearKitchenObjects()
    {
        kitchenObjects = null;
    }
    public bool HasKitchenObjects()
    {
        return kitchenObjects != null;
    }

}
