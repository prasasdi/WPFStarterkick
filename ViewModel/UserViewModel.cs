using Model;
using System.Reflection.Metadata;
using System.Windows.Input;

namespace ViewModel
{
    public class UserViewModel
    {
        private IList<Users> listOfUsers;

        public UserViewModel()
        {
            listOfUsers = new List<Users>()
            {
                new Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "A",
                    LastName = "AB",
                },
                new Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "A",
                    LastName = "AC",
                },
                new Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "A",
                    LastName = "AC",
                },
                new Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "E",
                    LastName = "AD",
                }
            };
        }

        public IList<Users> ListOfUsers
        {
            get => listOfUsers;
            set => listOfUsers = value;
        }

        #region Commands

        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get => mUpdater == null ? new Updater() : mUpdater;
            set => mUpdater = value;
        }

        private class Updater : ICommand
        {
            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter) => true;

            public void Execute(object? parameter)
            {
                throw new NotImplementedException();
            }
        }
        #endregion
    }
}
