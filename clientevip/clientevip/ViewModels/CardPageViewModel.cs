using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace clientevip.ViewModels
{
    public class CardPageViewModel : ViewModelBase
    {
        public CardPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
