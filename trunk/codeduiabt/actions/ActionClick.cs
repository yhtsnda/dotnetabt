﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.Factory;

namespace codeduiabt.actions
{
    internal class ActionClick : UIAAction
    {
        /// <summary>
        /// x-coordinate of clicking
        /// </summary>
        private int? X { get; set; }

        /// <summary>
        /// y-coordinate of clicking
        /// </summary>
        private int? Y { get; set; }

        /// <summary>
        /// left click or not (right click)
        /// </summary>
        private bool? LeftClick { get; set; }

        /// <summary>
        /// double click or not (single click)
        /// </summary>
        private bool? DoubleClick { get; set; }

        /// <summary>
        /// construct a 'click' action
        /// </summary>
        /// <param name="control">the UIA control</param>
        /// <param name="_params">other parameters</param>
        public ActionClick(UIItem control, Dictionary<string, string> _params)
            : base(control, _params)
        {
            Name = "click";

            try
            {
                if (Params["x"] != null)
                    X = int.Parse(Params["x"]);
                if (Params["y"] != null)
                    Y = int.Parse(Params["y"]);

                if (Params["left"] != null)
                    LeftClick = bool.Parse(Params["left"]);
                else
                    LeftClick = true;

                if (Params["double"] != null)
                    DoubleClick = bool.Parse(Params["double"]);
                else
                    DoubleClick = false;
            }
            catch (FormatException e)
            {
                throw new Exception("Invalid action params: " + e.Message);
            }
        }

        /// <summary>
        /// check whether the parameters are valid
        /// </summary>
        /// <returns>true - if params are valid</returns>
        public override bool IsValid()
        {
            // the UIA control exists
            if (Control != null)
 	            return true;

            // the coordinate is specified
            if (X != null && Y != null)
                return true;

            return false;
        }

        /// <summary>
        /// executing the action
        /// </summary>
        /// <returns>true - if click success</returns>
        public override int Execute()
        {
            // click on the UIA control
            if (Control != null)
            {
                if (LeftClick == true)
                {
                    if (DoubleClick == true)
                        Control.DoubleClick();
                    else
                        Control.Click();
                }
                else
                    // do not have "double right click"
                    Control.RightClick();
            }
            // click on the global desktop
            else
            {
                if (LeftClick == true)
                {
                    if (DoubleClick == true)
                        TestStack.White.InputDevices.Mouse.Instance.DoubleClick(new System.Windows.Point(X.Value, Y.Value));
                    else
                        TestStack.White.InputDevices.Mouse.Instance.Click(new System.Windows.Point(X.Value, Y.Value));
                }
                else
                    // do not have "double right click"
                    TestStack.White.InputDevices.Mouse.Instance.RightClick(new System.Windows.Point(X.Value, Y.Value));
            }

            return 0;
        }
    }
}
