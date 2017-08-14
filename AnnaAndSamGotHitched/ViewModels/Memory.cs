using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnaAndSamGotHitched.ViewModels
{
    public class MemoryViewModel
    {
        public MemoryViewModel(string p_Note)
        {
            Note = p_Note;
        }
        public bool HasImage { get; set; }

        public Guid? ImageRef { get; set; }

        public string Note { get; set; }
    }

    public class MemoryListingViewModel
    {
        public MemoryListingViewModel()
        {
            Memories = new List<MemoryViewModel>
            {
                new MemoryViewModel("Pudding and Stinky"),
                new MemoryViewModel("Looking good"),
                new MemoryViewModel("We'll never forget today"),
                new MemoryViewModel("I love you pudding"),
            };
        }

        public List<MemoryViewModel> Memories { get; set; }
    }
}
