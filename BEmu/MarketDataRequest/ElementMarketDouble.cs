﻿//------------------------------------------------------------------------------
// <copyright project="BEmu" file="MarketDataRequest/ElementMarketDouble.cs" company="Jordan Robinson">
//     Copyright (c) 2013 Jordan Robinson. All rights reserved.
//
//     The use of this software is governed by the Microsoft Public License
//     which is included with this distribution.
// </copyright>
//------------------------------------------------------------------------------

namespace BEmu.MarketDataRequest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class ElementMarketDouble : Element
    {
        private readonly double _value;
        private readonly string _name;

        internal ElementMarketDouble(string name, double value)
        {
            this._name = name;
            this._value = value;
        }

        public override Name Name { get { return new Name(this._name); } }
        public override int NumValues { get { return 1; } }
        public override int NumElements { get { return 0; } }
        public override bool IsNull { get { return false; } }
        public override bool IsArray { get { return false; } }
        public override bool IsComplexType { get { return base.IsComplexType; } }

        public override object this[int index]
        {
            get
            {
                if (index == 0)
                    return this._value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        internal override StringBuilder PrettyPrint(int tabIndent)
        {
            return base.PrettyPrintHelper(tabIndent, this._value.ToString("#.00"));
        }

        public override object GetValue()
        {
            return this._value;
        }

        public override double GetValueAsFloat64()
        {
            return this._value;
        }
    }
}
