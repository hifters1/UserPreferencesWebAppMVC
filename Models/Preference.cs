namespace UserPreferencesWebApp.Models
{
    public class Preference
    {
        public int PreferenceId { get; set; }
        public required string PreferenceValue { get; set; }
        
        public virtual ICollection<User>? Users { get; set; }
        
    }
}
