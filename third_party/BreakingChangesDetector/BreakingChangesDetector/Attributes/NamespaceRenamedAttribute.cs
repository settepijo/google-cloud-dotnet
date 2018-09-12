﻿/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using System;

namespace Infragistics // TODO: Use a more generic namespace name
{
    /// <summary>
    /// Represents a namespace which was renamed
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = true)]
    internal sealed class NamespaceRenamedAttribute : Attribute
    {
        /// <summary>
        /// Creates a new <see cref="NamespaceRenamedAttribute"/> instance.
        /// </summary>
        /// <param name="oldName">The name of the namespace in the older versions of the assembly.</param>
        /// <param name="newName">The name of the namespace in the newer versions of the assembly.</param>
        public NamespaceRenamedAttribute(string oldName, string newName)
        {
            OldName = oldName;
            NewName = newName;
        }

        /// <summary>
        /// Gets the name of the namespace in the newer versions of the assembly.
        /// </summary>
        public string NewName { get; }

        /// <summary>
        /// Gets the name of the namespace in the older versions of the assembly.
        /// </summary>
        public string OldName { get; }
    }
}