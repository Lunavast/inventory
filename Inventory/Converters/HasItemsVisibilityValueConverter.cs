﻿using MvvmCross.Platform.Converters;
using System;
using System.Globalization;

namespace Inventory.Converters
{
    public class HasItemsVisibilityValueConverter : MvxValueConverter<int, bool>
    {
        protected override bool Convert(int value, Type targetType, object parameter, CultureInfo culture)
        {
            int count = value;

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
