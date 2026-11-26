namespace VaegtApi;

public class WeightRepository
{
    private readonly List<Weight> _data = new();

    public List<Weight> GetAll()
    {
        return _data;
    }

    public Weight Add(Weight weight)
    {
        _data.Add(weight);
        return weight;
    }
}