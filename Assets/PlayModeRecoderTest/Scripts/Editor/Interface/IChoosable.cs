﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayModeRecoderTest
{
    public interface IChoosable
    {
        SegueProcess[] ItemData { get; }
        void Choice (GUIContent select);
    }
}