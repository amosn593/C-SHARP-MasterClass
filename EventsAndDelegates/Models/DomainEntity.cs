using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAndDelegates.Models
{
    public abstract record DomainEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; init; } = DateTime.Now;
        public DateTime UpdatedDate { get; init; } = DateTime.Now;
    }
}