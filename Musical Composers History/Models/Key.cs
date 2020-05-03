using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musical_Composers_History.Models
{
    public class Key
    {
        public Key()
        {
            Pieces = new List<Piece>();
        }
        int Id { get; set; }
        int Name { get; set; }
        public virtual ICollection<Piece> Pieces { get; set; } 
    }
}
