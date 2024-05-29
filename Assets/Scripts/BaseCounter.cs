using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectsParents
{
   
    [SerializeField] private Transform counterTopPoint;

    private KitchenObjects kitchenObjects;

    public virtual void Interact(Player player)
    {
        Debug.LogError("BaseCounter.Interact();");
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
