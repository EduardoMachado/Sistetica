using System;
using System.Collections.Generic;
using System.Text;

namespace Sistetica.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }
        public string DataAniversario { get; set; }
        public string Cpf { get; set; }
    }
}
