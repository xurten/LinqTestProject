﻿using System.Collections;

namespace LinqProject.Utils.FileOperators
{
    public class XmlOperator : IFileOpenOperator
    {
        public bool Read()
        {
            return true;
        }


        public bool Save(IEnumerable list)
        {
            return true;
        }
    }
}
