using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;

[Serializable]
public struct _transform
{
    public float positionX;
    public float positionY;
    public float positionZ;

    public float rotationX;
    public float rotationY;
    public float rotationZ;
    public float rotationW;
}

[Serializable]
public class DataStorage
{
    public _transform leftDoor;
    //public _transform rightDoor;
    //public _transform cube1;
    //public _transform cube2;
    //public _transform cube3;
    //public _transform cube4;
}
