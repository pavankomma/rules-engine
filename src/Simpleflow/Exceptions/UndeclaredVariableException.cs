﻿// Copyright (c) navtech.io. All rights reserved.
// See License in the project root for license information.

using System;

namespace Simpleflow.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class UndeclaredVariableException : SimpleflowException
    {
        // TODO

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public UndeclaredVariableException(string name) : base($"Variable '{name}' is not declared.")
        {
            VariableName = name;
        }

        public string VariableName { get; }
    }
}