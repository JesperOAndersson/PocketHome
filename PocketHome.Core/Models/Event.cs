using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketHome.Core.Models
{
    public class Event
    {
        [Key]
		public int EventId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
        [ForeignKey("Trigger")]
        public IEnumerable<Trigger> Triggers { get; set; }
        [ForeignKey("ConditionElement")]
        public IEnumerable<ConditionElement> Conditions { get; set; }
        [ForeignKey("VeraAction")]
        public IEnumerable<VeraAction> Actions { get; set; }
	}
}
