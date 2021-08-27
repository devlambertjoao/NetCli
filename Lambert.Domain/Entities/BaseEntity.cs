using System;
using System.Collections.Generic;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Lambert.Domain.Entities
{
	public abstract class BaseEntity<TKeyType>
		{
			[Key]
			public virtual TKeyType Id { get; set; }
			public DateTime InsertDate { get; set; }
			public DateTime UpdateDate { get; set; }
			public bool IsValid { get; set; }
			public IList<string> Errors { get; set; }
				
			protected BaseEntity(TKeyType id = default)
			{
				Id = id;
			}

			protected void Validate<TEntity>(TEntity entity, AbstractValidator<TEntity> validator) {
				var results = validator.Validate(entity);
				IsValid = results.IsValid;
				Errors = new List<string>();
				results.Errors.ForEach(error => Errors.Add(error.ErrorMessage));
			}
		}
}
