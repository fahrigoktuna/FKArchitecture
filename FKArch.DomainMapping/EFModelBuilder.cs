using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace FKArch.DomainMapping
{
    public class EFModelBuilder
    {
        static DbModelBuilder _builder = null;
        static DbCompiledModel _model = null;
     

        public static DbCompiledModel Model(SqlConnection con)
        {
            if ((_builder == null) || (_model == null))
            {
                _builder = new DbModelBuilder();
                _builder.Configurations.Add(new ProductConfiguration());
                
                var edm = _builder.Build(con);
                _model = edm.Compile();
            }
            return _model;
          
        }
    }
}
