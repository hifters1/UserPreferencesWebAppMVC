namespace UserPreferencesWebApp.Models
{
    //This model was used to create the Preferences table using the migration tool.
    public class Preference
    {
        public int PreferenceId { get; set; }   //Entity framework treats as primary key
        public required string PreferenceValue { get; set; }  //Required
        
        public virtual ICollection<User>? Users { get; set; } //Creates a list of preferences for displaying
                                                              //Entity framework will load when needed
        
    }
}
