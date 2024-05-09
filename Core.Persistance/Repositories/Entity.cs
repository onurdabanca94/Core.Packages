using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Repositories;

public class Entity<TId>:IEntityTimeStamps
{
    public TId Id { get; set; } //common - ortak alan
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set;}
    public DateTime? DeletedDate { get; set; }

    public Entity()
    {
        Id = default; // hiçbir şey verilmezse o Id'nin türü ne ise onu versin (örn: int ise 0 versin)
    }
    public Entity(TId id)
    {
        Id = id;
    }
}
