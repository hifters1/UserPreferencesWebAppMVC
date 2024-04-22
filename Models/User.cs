namespace UserPreferencesWebApp.Models
{
    //This model was used to create the table Users using the migration tool in PMC.
    public class User
    { 
        public int UserId { get; set; }          //Entity framework treats as primary key
        public required string UserName { get; set; } //Required for display purposes
        public int? PreferenceId { get; set; }   //Have decided that this field is not needed
        public string? PreferenceValue { get; set; }
        public virtual Preference? Preferences { get; set; } //Single instance to Preferences
        
    }
}
