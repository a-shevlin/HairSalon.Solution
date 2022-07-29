using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public double PhoneNumber { get; set; }
    public int StylistId { get; set; }
    public string Pronoun { get; set; }
    public string Email { get; set; }

    public virtual Stylist Stylist { get; set; }
  }
}