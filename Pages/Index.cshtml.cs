using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace SteamProject.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<string> Cards { get; private set; }
    public List<string> SelectedCards { get; private set; } = new List<string>();

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        InitializeDeck();
    }

    public void OnGet()
    {
        // Cards are already initialized and optionally could be shuffled here
    }

    private void InitializeDeck()
    {
        Cards = new List<string>
        {
            "Ace of Spades", "Two of Spades", "Three of Spades", "Four of Spades", "Five of Spades", "Six of Spades", "Seven of Spades", "Eight of Spades", "Nine of Spades", "Ten of Spades", "Jack of Spades", "Queen of Spades", "King of Spades",
            "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts", "Seven of Hearts", "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts",
            "Ace of Clubs", "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs", "Seven of Clubs", "Eight of Clubs", "Nine of Clubs", "Ten of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs",
            "Ace of Diamonds", "Two of Diamonds", "Three of Diamonds", "Four of Diamonds", "Five of Diamonds", "Six of Diamonds", "Seven of Diamonds", "Eight of Diamonds", "Nine of Diamonds", "Ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds"
        };
    }

    public IActionResult OnPostShuffle()
    {
        SelectedCards.Clear();
        ShuffleDeck();
        return Page();
    }

    public IActionResult OnPostSelectCard(string card)
    {
        if (!SelectedCards.Contains(card))
        {
            SelectedCards.Add(card);
        }
        return Page();
    }

    private void ShuffleDeck()
    {
        Random rng = new Random();
        int n = Cards.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = Cards[k];
            Cards[k] = Cards[n];
            Cards[n] = value;
        }
    }
}
