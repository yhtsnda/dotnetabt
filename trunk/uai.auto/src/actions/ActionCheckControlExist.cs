﻿using System;
using System.Collections.Generic;

using abt.model;

namespace uia_auto.actions
{
    class ActionCheckControlExist : UIAAction
    {
        /// <summary>
        /// constructor
        /// </summary>
        public ActionCheckControlExist()
        {
            Name = @"check control exist";
        }

        /// <summary>
        /// check whether the parameters are valid
        /// </summary>
        /// <returns>true - if params are valid</returns>
        public override bool IsValid()
        {
            // the UIA window exists
            if (Window == null)
                throw new Exception(Constants.Messages.Error_Matching_Window_NotFound);

            return true;
        }

        /// <summary>
        /// executing the action
        /// </summary>
        /// <returns>true - if click success</returns>
        public override int Execute()
        {
            Result = ActionResult.FAILED;

            if (Control != null)
                Result = ActionResult.PASSED;

            return 0;
        }
    }
}
