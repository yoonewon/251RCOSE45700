using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConditionsDB
{
    public static Dictionary<ConditionID, Condition> Conditions { get; set; } = new Dictionary<ConditionID, Condition>()
    {
        {
            ConditionID.psn,
            new Condition(){

                Name = "Poision",
                StartMessage = "has been poisioned",
                OnAfterTurn = (Pokemon pokemon) =>
                {
                    pokemon.UpdateHP(pokemon.MaxHP / 8);
                    pokemon.StatusChanges.Enqueue($"{pokemon.Base.Name} hurt itself due to poison");
                }
            }
        },

        {
            ConditionID.brn,
            new Condition(){

                Name = "Burn",
                StartMessage = "has been burned",
                OnAfterTurn = (Pokemon pokemon) =>
                {
                    pokemon.UpdateHP(pokemon.MaxHP / 16);
                    pokemon.StatusChanges.Enqueue($"{pokemon.Base.Name} hurt itself due to poison");
                }
            }
        }

    };
}

public enum ConditionID
{
    none, psn, brn, slp, par, frz
}
