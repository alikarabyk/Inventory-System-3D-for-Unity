using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Consumable")]
public class ConsumableClass : ItemClass
{
    //data specific to consumable class 

    [Header("Consumable")] 
    public float healthAdded;

    public override void Use(PlayerController caller)
    {
        base.Use(caller);
        Debug.Log("Eat Consumable");
        caller.inventory.UseSelected();
    }

    public override ConsumableClass GetConsumable() { return this; }
}
