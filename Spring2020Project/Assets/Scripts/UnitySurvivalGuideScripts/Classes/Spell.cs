using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class Spell
{
   public string spellName;
   public int levelRequired;
   public int itemIDRequired;
   public int experienceGained;

   public Spell(string name, int levelReq, int itemIDReq, int exGained)
   {
      this.spellName = name;
      this.levelRequired = levelReq;
      this.itemIDRequired = itemIDReq;
      this.experienceGained = exGained;
   }

   public void CastSpell()
   {
      UnityEngine.Debug.Log("Spelled Casted: " + this.spellName);
      
   }
}
