using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoRedis.Model
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $" === Info ===" +
                   $"Código = {this.Id}\n" +
                   $"Nome = {this.Name}\n" +
                   $"Email = {this.Email}";
        }
    }
}
