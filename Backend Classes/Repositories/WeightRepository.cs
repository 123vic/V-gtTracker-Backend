namespace VaegtApi;

public class WeightRepository
{
    private readonly List<Weight> _data = new();

    public IReadOnlyList<Weight> GetAll() => _data;

    public Weight Add(Weight weight)
    {
        weight.Time = DateTime.Now;
        _data.Add(weight);
        return weight;
    }
}