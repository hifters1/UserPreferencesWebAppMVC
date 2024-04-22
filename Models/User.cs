namespace UserPreferencesWebApp.Models
{
    public class User
    { 
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int PreferenceId { get; set; }
        public string PreferenceValue { get; set; }
        public virtual Preference Preferences { get; set; }
        //public virtual ICollection<Preference> Preferences { get; set;}
    }
}
