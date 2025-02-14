// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace CommunityToolkit.WinUI.UI.Controls
{
    internal class DataGridCellEventArgs : EventArgs
    {
        internal DataGridCellEventArgs(DataGridCell dataGridCell)
        {
            Debug.Assert(dataGridCell != null, "Expected non-null dataGridCell parameter.");

            this.Cell = dataGridCell;
        }

        internal DataGridCell Cell
        {
            get;
            private set;
        }
    }
}