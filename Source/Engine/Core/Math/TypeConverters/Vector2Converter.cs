// Copyright (c) 2012-2023 Wojciech Figat. All rights reserved.

#if FLAX_EDITOR
using System;
using System.ComponentModel;
using System.Globalization;

namespace FlaxEngine.TypeConverters
{
    internal class Vector2Converter : VectorConverter
    {
        /// <inheritdoc />
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string str)
            {
                string[] v = GetParts(str);
                return new Vector2(float.Parse(v[0], culture), float.Parse(v[1], culture));
            }
            return base.ConvertFrom(context, culture, value);
        }

        /// <inheritdoc />
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                var v = (Vector2)value;
                return v.X.ToString(culture) + "," + v.Y.ToString(culture);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
#endif
