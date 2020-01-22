﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Activable : MonoBehaviour
{
    public abstract bool IsActive();
    public abstract void activate();
}
