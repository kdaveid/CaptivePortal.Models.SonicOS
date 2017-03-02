// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS.SonicOS
{
    public static class SonicOSHelper
    {
        public static string Convert2HMAC(string input)
        {
            input = input.Replace("%", "%25");
            input = input.Replace(":", "%3A");
            input = input.Replace(" ", "%20");
            input = input.Replace("?", "%3F");
            input = input.Replace("+", "%2B");
            input = input.Replace("&", "%26");
            input = input.Replace("=", "%3D");

            return input;
        }
    }
}
