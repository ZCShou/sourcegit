﻿using Avalonia.Data.Converters;

namespace SourceGit.Converters
{
    public static class FontSizeModifyConverters
    {
        public static readonly FuncValueConverter<double, double> Increase =
            new FuncValueConverter<double, double>(v => v + 1.0);

        public static readonly FuncValueConverter<double, double> Decrease =
            new FuncValueConverter<double, double>(v => v - 1.0);
    }
}
