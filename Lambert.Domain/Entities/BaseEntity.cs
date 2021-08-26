using System;

namespace Lambert.Domain.Entities
{
		public abstract class BaseEntity<TKeyType>
		{
				public virtual TKeyType Id { get; set; }
				public DateTime InsertDate;
				public DateTime UpdateDate;
				
				protected BaseEntity(TKeyType id = default)
				{
						Id = id;
				}
		}
}
