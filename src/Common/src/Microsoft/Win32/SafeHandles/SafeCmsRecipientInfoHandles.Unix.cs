﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.Win32.SafeHandles
{
    internal class SafeSharedCmsRecipientInfoStackHandle : SafeInteriorHandle
    {
        private SafeSharedCmsRecipientInfoStackHandle() :
            base(IntPtr.Zero, ownsHandle: true)
        {
        }
    }

    internal class SafeSharedCmsRecipientInfoHandle : SafeInteriorHandle
    {
        private SafeSharedCmsRecipientInfoHandle() :
            base(IntPtr.Zero, ownsHandle: true)
        {
        }
    }
}
