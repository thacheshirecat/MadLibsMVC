namespace MadLibsInC.Models
{
  public class MadLibWords
  {
    private string _nameOne;
    private string _locationOne;
    private string _animalOne;
    private string _verbOne;
    private string _verbTwo;

    public string GetNameOne()
    {
      return _nameOne;
    }
    public void SetNameOne(string newNameOne)
    {
      _nameOne = newNameOne;
    }

    public string GetLocationOne()
    {
      return _locationOne;
    }
    public void SetLocationOne(string newLocationOne)
    {
      _locationOne = newLocationOne;
    }

    public string GetAnimalOne()
    {
      return _animalOne;
    }
    public void SetAnimalOne(string newAnimalOne)
    {
      _animalOne = newAnimalOne;
    }

    public string GetVerbOne()
    {
      return _verbOne;
    }
    public void SetVerbOne(string newVerbOne)
    {
      _verbOne = newVerbOne;
    }

    public string GetVerbTwo()
    {
      return _verbTwo;
    }
    public void SetVerbTwo(string newVerbTwo)
    {
      _verbTwo = newVerbTwo;
    }

  }
}
