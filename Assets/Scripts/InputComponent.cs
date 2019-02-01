using System;
using Unity.Entities;
using UnityEngine;

[Serializable]
public struct InputData : ISharedComponentData
{
    public float horizontal;
    public float vertical;
}
public class InputComponent : SharedComponentDataWrapper<InputData> { }