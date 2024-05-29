using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class ClearCounter : BaseCounter 
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;


    public override void Interact(Player player)
    {
        if (!HasKitchenObjects())
        {
            if (player.HasKitchenObjects())
            {
                player.GetKitchenObjects().SetKitchenObjectParent(this);
            }
        }
        else
        {
            if(player.HasKitchenObjects())
            {

            }
            else
            {
                GetKitchenObjects().SetKitchenObjectParent(player); 
            }
        }
    }



}
