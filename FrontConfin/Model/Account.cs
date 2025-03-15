using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontConfin.Model
{
    public enum Situation { close, open}
    public class Account
    {
        public Guid Id { get; set; }
        public Guid PersonaId { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public Situation Situation { get; set; }
    }
}