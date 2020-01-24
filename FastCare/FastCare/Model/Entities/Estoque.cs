using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCare.Model.Entities
{
    partial class tb_estoque
    {
        public string nm_produto { get { return tb_suprimento.nm_produto; } }
    }

}
