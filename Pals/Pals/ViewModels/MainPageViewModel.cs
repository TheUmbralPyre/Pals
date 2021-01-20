using Pals.Models;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace Pals.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<Pal> pals = new ObservableCollection<Pal>();
        public ObservableCollection<Pal> Pals
        {
            get { return pals; }
            set { SetProperty(ref pals, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService) { }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);

            Pals.Add(new Pal() { Name = "Steve", CoolFact = "Who's a Good Boy? I'll give you a hint - it's him!" });
            Pals.Add(new Pal() { Name = "Charles", CoolFact = "Don't let his appearance fool you, he likes to cuddle!" });
            Pals.Add(new Pal() { Name = "Jef", CoolFact = "Really like food!" });
        }
    }
}