﻿using System.ComponentModel.DataAnnotations.Schema;

namespace XploreFlixDomainLayer.Entities;

public class Card
{
	public int Id { get; set; }
	[ForeignKey("Movie")]
	public Guid? MovieId { get; set; }
	[ForeignKey("User")]
	public string? UserId { get; set; }
	public virtual Movie? Movie { get; set; }
	public virtual User? User { get; set; }
}
