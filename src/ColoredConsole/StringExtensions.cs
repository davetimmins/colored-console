﻿// <copyright file="StringExtensions.cs" company="ColoredConsole contributors">
//  Copyright (c) ColoredConsole contributors. (coloredconsole@gmail.com)
// </copyright>

namespace ColoredConsole
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Convenience extension methods for colorizing strings.
    /// </summary>
    public static class StringExtensions
    {
        [SuppressMessage(
            "Microsoft.Naming",
            "CA1719:ParameterNamesShouldNotMatchMemberNames",
            MessageId = "1#",
            Justification = "By design.")]
        public static ColorToken Color(this string text, ConsoleColor? color)
        {
            return new ColorToken(text, color);
        }

        public static ColorToken Black(this string text)
        {
            return text.Color(ConsoleColor.Black);
        }

        public static ColorToken Blue(this string text)
        {
            return text.Color(ConsoleColor.Blue);
        }

        public static ColorToken Cyan(this string text)
        {
            return text.Color(ConsoleColor.Cyan);
        }

        public static ColorToken DarkBlue(this string text)
        {
            return text.Color(ConsoleColor.DarkBlue);
        }

        public static ColorToken DarkCyan(this string text)
        {
            return text.Color(ConsoleColor.DarkCyan);
        }

        public static ColorToken DarkGray(this string text)
        {
            return text.Color(ConsoleColor.DarkGray);
        }

        public static ColorToken DarkGreen(this string text)
        {
            return text.Color(ConsoleColor.DarkGreen);
        }

        public static ColorToken DarkMagenta(this string text)
        {
            return text.Color(ConsoleColor.DarkMagenta);
        }

        public static ColorToken DarkRed(this string text)
        {
            return text.Color(ConsoleColor.DarkRed);
        }

        public static ColorToken DarkYellow(this string text)
        {
            return text.Color(ConsoleColor.DarkYellow);
        }

        public static ColorToken Gray(this string text)
        {
            return text.Color(ConsoleColor.Gray);
        }

        public static ColorToken Green(this string text)
        {
            return text.Color(ConsoleColor.Green);
        }

        public static ColorToken Magenta(this string text)
        {
            return text.Color(ConsoleColor.Magenta);
        }

        public static ColorToken Red(this string text)
        {
            return text.Color(ConsoleColor.Red);
        }

        public static ColorToken White(this string text)
        {
            return text.Color(ConsoleColor.White);
        }

        public static ColorToken Yellow(this string text)
        {
            return text.Color(ConsoleColor.Yellow);
        }

        public static ColorToken On(this string text, ConsoleColor? backgroundColor)
        {
            return new ColorToken(text, null, backgroundColor);
        }

        public static ColorToken OnBlack(this string text)
        {
            return text.On(ConsoleColor.Black);
        }

        public static ColorToken OnBlue(this string text)
        {
            return text.On(ConsoleColor.Blue);
        }

        public static ColorToken OnCyan(this string text)
        {
            return text.On(ConsoleColor.Cyan);
        }

        public static ColorToken OnDarkBlue(this string text)
        {
            return text.On(ConsoleColor.DarkBlue);
        }

        public static ColorToken OnDarkCyan(this string text)
        {
            return text.On(ConsoleColor.DarkCyan);
        }

        public static ColorToken OnDarkGray(this string text)
        {
            return text.On(ConsoleColor.DarkGray);
        }

        public static ColorToken OnDarkGreen(this string text)
        {
            return text.On(ConsoleColor.DarkGreen);
        }

        public static ColorToken OnDarkMagenta(this string text)
        {
            return text.On(ConsoleColor.DarkMagenta);
        }

        public static ColorToken OnDarkRed(this string text)
        {
            return text.On(ConsoleColor.DarkRed);
        }

        public static ColorToken OnDarkYellow(this string text)
        {
            return text.On(ConsoleColor.DarkYellow);
        }

        public static ColorToken OnGray(this string text)
        {
            return text.On(ConsoleColor.Gray);
        }

        public static ColorToken OnGreen(this string text)
        {
            return text.On(ConsoleColor.Green);
        }

        public static ColorToken OnMagenta(this string text)
        {
            return text.On(ConsoleColor.Magenta);
        }

        public static ColorToken OnRed(this string text)
        {
            return text.On(ConsoleColor.Red);
        }

        public static ColorToken OnWhite(this string text)
        {
            return text.On(ConsoleColor.White);
        }

        public static ColorToken OnYellow(this string text)
        {
            return text.On(ConsoleColor.Yellow);
        }
    }
}
