namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string SearchFor { get; set; }
    public string Sentence { get; set; }

    public RepeatCounter(string searchFor)
    {
      SearchFor = searchFor.ToLower();
    }

    public RepeatCounter(string searchFor, string sentence)
    {
      SearchFor = searchFor.ToLower();
      Sentence = sentence.ToLower();
    }

    public bool IsValidInput()
    {
      if (!SearchFor.Contains(" ") && !string.IsNullOrWhiteSpace(SearchFor) && !string.IsNullOrEmpty(SearchFor))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    
    public bool ContainsWord()
    {
      return Sentence.Contains(SearchFor);
    }

    public int FindWord()
    {
      int matchCount = 0;
      string[] sentenceArr = Sentence.Split(" ");
      foreach (string word in sentenceArr)
      {
        if (word == SearchFor)
        {
          matchCount++;
        }
      }
      return matchCount;
    }
  }
}
