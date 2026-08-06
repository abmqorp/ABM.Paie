using ABM.Paie.Formation.Dsn.Models;

namespace ABM.Paie.Formation.Training.Models;

public class Course
{
    public double Price { get; set; }
    public IEnumerable<Block> Blocks { get; set; } = [];
}
