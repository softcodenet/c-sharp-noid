﻿// Copyright (c) 2016 NoID Developers
// Distributed under the MIT/X11 software license, see the accompanying
// file COPYING or http://www.opensource.org/licenses/mit-license.php.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoID.Base.Algorithms
{
    public static partial class StringDiffAlgorithm
    {
        public static double OverlapCoefficient(this string source, string target)
        {
            return (Convert.ToDouble(source.Intersect(target).Count())) / Convert.ToDouble(Math.Min(source.Length, target.Length));
        }
    }
}