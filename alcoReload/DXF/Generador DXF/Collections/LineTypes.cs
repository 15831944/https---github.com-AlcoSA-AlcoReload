#region DXF.Generador_DXF, Copyright(C) 2015 Daniel Carvajal, Licensed under LGPL.
// 
//                         DXF.Generador_DXF library
//  Copyright (C) 2009-2015 Daniel Carvajal (haplokuon@gmail.com)
//  
//  This library is free software; you can redistribute it and/or
//  modify it under the terms of the GNU Lesser General Public
//  License as published by the Free Software Foundation; either
//  version 2.1 of the License, or (at your option) any later version.
//  
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
//  FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
//  COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
//  IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using DXF.Generador_DXF.Tables;

namespace DXF.Generador_DXF.Collections
{
    /// <summary>
    /// Represents a collection of line types.
    /// </summary>
    public sealed class LineTypes :
        TableObjects<LineType>
    {

        #region constructor

        internal LineTypes(DxfDocument document, string handle = null)
            : this(document,0,handle)
        {
        }

        internal LineTypes(DxfDocument document, int capacity, string handle = null)
            : base(document,
            new Dictionary<string, LineType>(capacity, StringComparer.OrdinalIgnoreCase),
            new Dictionary<string, List<DxfObject>>(capacity, StringComparer.OrdinalIgnoreCase),
            DxfObjectCode.LineTypeTable,
            handle)
        {
            this.maxCapacity = short.MaxValue;
        }

        #endregion

        #region override methods

        /// <summary>
        /// Adds a line type to the list.
        /// </summary>
        /// <param name="lineType"><see cref="LineType">LineType</see> to add to the list.</param>
        /// <param name="assignHandle">Specifies if a handle needs to be generated for the line type parameter.</param>
        /// <returns>
        /// If a line type already exists with the same name as the instance that is being added the method returns the existing line type,
        /// if not it will return the new line type.
        /// </returns>
        internal override LineType Add(LineType lineType, bool assignHandle)
        {
            if (this.list.Count >= this.maxCapacity)
                throw new OverflowException(string.Format("Table overflow. The maximum number of elements the table {0} can have is {1}", this.codeName, this.maxCapacity));

            LineType add;

            if (this.list.TryGetValue(lineType.Name, out add))
                return add;

            if (assignHandle || string.IsNullOrEmpty(lineType.Handle))
                this.document.NumHandles = lineType.AsignHandle(this.document.NumHandles);

            this.list.Add(lineType.Name, lineType);
            this.document.AddedObjects.Add(lineType.Handle, lineType);
            this.references.Add(lineType.Name, new List<DxfObject>());

            lineType.Owner = this;

            lineType.NameChange += this.Item_NameChange;

            return lineType;
        }

        /// <summary>
        /// Removes a line type.
        /// </summary>
        /// <param name="name"><see cref="LineType">LineType</see> name to remove from the document.</param>
        /// <returns>True if the line type has been successfully removed, or false otherwise.</returns>
        /// <remarks>Reserved line types or any other referenced by objects cannot be removed.</remarks>
        public override bool Remove(string name)
        {
            return this.Remove(this[name]);
        }

        /// <summary>
        /// Removes a line type.
        /// </summary>
        /// <param name="lineType"><see cref="LineType">LineType</see> to remove from the document.</param>
        /// <returns>True if the line type has been successfully removed, or false otherwise.</returns>
        /// <remarks>Reserved line types or any other referenced by objects cannot be removed.</remarks>
        public override bool Remove(LineType lineType)
        {
            if (lineType == null)
                return false;

            if (!this.Contains(lineType))
                return false;

            if (lineType.IsReserved)
                return false;

            if (this.references[lineType.Name].Count != 0)
                return false;

            this.document.AddedObjects.Remove(lineType.Handle);
            this.references.Remove(lineType.Name);
            this.list.Remove(lineType.Name);

            lineType.Handle = null;
            lineType.Owner = null;

            lineType.NameChange -= this.Item_NameChange;

            return true;
        }

        #endregion

        #region LineType events

        private void Item_NameChange(TableObject sender, TableObjectChangeEventArgs<string> e)
        {
            if (this.Contains(e.NewValue))
                throw new ArgumentException("There is already another line type with the same name.");

            this.list.Remove(sender.Name);
            this.list.Add(e.NewValue, (LineType)sender);

            List<DxfObject> refs = this.references[sender.Name];
            this.references.Remove(sender.Name);
            this.references.Add(e.NewValue, refs);
        }

        #endregion

    }
}