﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly : InternalsVisibleTo ("Tests")]
namespace PlayModeRecoderTest
{
    partial class MenuViewModel
    {
        private MenuType type;
        private string selectedMenuTitle;

        public MenuViewModel (MenuType type)
        {
            this.type = type;
        }
    }

    partial class MenuViewModel : ISelected
    {
        public string Selected
        {
            get
            {
                return selectedMenuTitle;
            }
            set
            {
                selectedMenuTitle = value;
            }
        }
    }

    partial class MenuViewModel : IChoosable
    {
        public string[] ItemData
        {
            get
            {
                switch (type)
                {
                    case MenuType.Node:
                        return NodeSegue.Items;
                    case MenuType.Window:
                        return WindowSegue.Items;
                }
                throw new Exception (Application.productName + " Error");
            }
        }

        public void Choice (object select)
        {
            var selected = select.ToString ();
            selectedMenuTitle = selected;
        }
    }
}