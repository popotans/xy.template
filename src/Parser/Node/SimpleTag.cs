﻿using System;
using System.Collections.Generic;
using System.Text;


namespace XY.Template.Parser.Node
{
    public abstract class SimpleTag : Tag
    {
        public SimpleTag(ElementType type, Int32 line, Int32 col)
            : base(type, line, col)
        {
            
        }

        public override void Parse(VariableScope vars, System.IO.TextWriter writer)
        {
            writer.Write(this.Parse(vars));
        }
    }
}
