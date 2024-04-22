namespace UserPreferencesWebApp.Models
{
    public class Preference
    {
        public int PreferenceId { get; set; }
        public string PreferenceValue { get; set; }
        //public int UserId { get; set; }
        public virtual ICollection<User> Users { get; set; }
        
    }
}
