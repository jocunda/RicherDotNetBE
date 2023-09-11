﻿namespace RicherBE.Models
  {
  public class Item
    {
    public string Id { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
    public bool? Deleteable { get; set; }
    public string CreatedById { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }= DateTime.Now;
    }
  }
