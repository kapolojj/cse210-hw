class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private string _text;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        var hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            var word = _words[random.Next(_words.Count)];
            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        var displayedText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}: {displayedText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}