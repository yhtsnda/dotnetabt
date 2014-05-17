﻿using System;
using System.Collections.Generic;

namespace uia_auto.model
{
    public interface IAction
    {
        /// <summary>
        /// name of the action
        /// </summary>
        string Name { get; }

        /// <summary>
        /// parameters of the action
        /// </summary>
        Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// check if the parameters are valid for executing
        /// derived class should re-implement this function
        /// </summary>
        /// <returns>true - if parameters are ready for executing</returns>
        bool IsValid();

        /// <summary>
        /// execute the action
        /// derived class should re-implement this function for actual executing
        /// </summary>
        /// <returns>0 - if executing sucessfully</returns>
        int Execute();

        /// <summary>
        /// reset action after executing
        /// </summary>
        void Reset();
    }
}
