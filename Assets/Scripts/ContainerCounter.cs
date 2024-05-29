
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabbedObject;


    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;

    public override void Interact(Player player)
    {
        if (!player.HasKitchenObjects())
        {
            Transform kitchenObjectSoTransform = Instantiate(kitchenObjectsSO.prefab);
            kitchenObjectSoTransform.GetComponent<KitchenObjects>().SetKitchenObjectParent(player);
            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);

        }
    }

}