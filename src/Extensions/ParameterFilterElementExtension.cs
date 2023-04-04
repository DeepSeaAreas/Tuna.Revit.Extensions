﻿///************************************************************************************
///   Author:十五
///   CretaeTime:2023/3/3 21:46:09
///   Mail:1012201478@qq.com
///   Github:https://github.com/shichuyibushishiwu
///
///   Description:
///
///************************************************************************************

using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Extension
{
    public static class ParameterFilterElementExtension
    {
        public static ElementFilter GetElementFilter(this ParameterFilterElement element)
        {
#if Rvt_18
            var rules = element.GetRules();
            if (rules.Count > 0)
            {
                return new ElementParameterFilter(rules);
            }
            return null;
#endif

#if Rvt_23 || Rvt_22 || Rvt_21 || Rvt_20 || Rvt_19
            return element.GetElementFilter();
#endif
        }
    }
}
