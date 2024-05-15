namespace Model
{
    public class Users : OnNotifyPropertyChangeBase
    {
        private Guid id;
        private string firstName;
        private string lastName;
        
        // getter setter
        public Guid Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string FirstName
        {
            get => firstName;   
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
    }
}
