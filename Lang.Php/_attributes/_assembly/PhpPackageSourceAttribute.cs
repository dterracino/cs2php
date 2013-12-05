﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lang.Php
{

    /// <summary>
    /// PhpPackageSourceAttribute is used to decorate assembly with information about location of 
    /// php compiled library that should be downloaded and used instead of cs2php translated code.
    /// Usefull with facade only .NET libraries i.e. mPDF
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public class PhpPackageSourceAttribute : Attribute
    {
        public PhpPackageSourceAttribute(string sourceUri)
        {
            this.SourceUri = sourceUri;
        }
        public string SourceUri { get; private set; }
    }
}
