using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SymClass
{
    abstract class Symbol
    {

        public string symType { get; set; }

        public Symbol() 
        {
        }

        public Symbol(string SymbolClassName) 
        {
            this.symType = SymbolClassName;
        }

        
        public List<DataRow> GetLst(DataTable dt) 
        {
            return dt.AsEnumerable().ToList();
        }
        


    }
}
