﻿// Copyright 2017 Krasimir Kostadinov. All rights reserved. Use of this source code is governed by the Apache License 2.0, as found on https://www.apache.org/licenses/LICENSE-2.0

namespace WhatsNewInCS7
{
    public class OutParams
    {
        /// <summary>
        /// Converts an expression to int and if successful, returns the value obtained
        /// </summary>
        /// <param name="expression">The expression that will be tried for conversion into int</param>
        /// <returns>A value if the expression is a valid int and no value otherwise</returns>
        public static int? TryConvertToInt(string expression)
        {
            // Out parameters can now be declared inline
            return (int.TryParse(expression, out int result)) ? result : new int?();
        }
    }
}
