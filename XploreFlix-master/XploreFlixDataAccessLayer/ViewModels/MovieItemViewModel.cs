﻿using XploreFlixDomainLayer.Entities;

namespace XploreFlixDataAccessLayer.ViewModels;

public class MovieItemViewModel
{
	public Guid ActorId { get; set; }
	public Guid MovieId { get; set; }
	public int CinemaId { get; set; }
	public int CategoryId { get; set; }
	public int ProducerId { get; set; }
	public List<Movie>? Movies { get; set; }
	public List<Cinema>? Cinemas { get; set; }
	public List<Category>? Categories { get; set; }
	public List<Actor>? Actors { get; set; }
	public List<Producer>? Producers { get; set; }
	public List<MovieActor>? MovieActors { get; set; }
}
