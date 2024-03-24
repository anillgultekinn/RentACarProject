using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Model : Entity<Guid>
{
    public Guid BrandId { get; set; }
    public Guid FuelId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }

    public virtual Brand? Brand { get; set; }
    public virtual Fuel? Fuel { get; set; }

}