﻿// Copyright (c) 2018 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT licence. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GenericBizRunner
{
    /// <summary>
    /// This contains the error hanlding part of the GenericBizRunner
    /// </summary>
    public class StatusGenericHandler<T> : StatusGenericHandler, IStatusGeneric<T>
    {
        private T _result;

        /// <summary>
        /// This is the returned result
        /// </summary>
        public T Result
        {
            get => HasErrors ? default(T) : _result;
            set => _result = value;
        }
    }
}