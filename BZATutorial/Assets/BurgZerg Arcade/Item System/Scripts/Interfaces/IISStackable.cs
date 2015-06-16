using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
    public interface IISStackable
    {
        int MaxStackSize { get; }
        int StackSize(int amount);
        
    }
}