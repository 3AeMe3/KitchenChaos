using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class ClearCounter : MonoBehaviour , IKitchenObjectsParents
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;
    [SerializeField] private Transform counterTopPoint;
    private KitchenObjects kitchenObjects;


    public void Interact(Player player)
    {
        //no hay nada en la caja
        if(kitchenObjects == null)
        {
            Transform kitchenObjectSoTransform = Instantiate(kitchenObjectsSO.prefab, counterTopPoint);
            kitchenObjectSoTransform.GetComponent<KitchenObjects>().SetKitchenObjectParent(this);
        }
        else
        {
            kitchenObjects.SetKitchenObjectParent(player);
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
