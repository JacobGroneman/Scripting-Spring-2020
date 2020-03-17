using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface cpICommand
{
   void Execute();
   void Undo();
}
