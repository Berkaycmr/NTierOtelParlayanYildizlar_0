namespace Project.ENTITIES.Models
{
    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }



    }
}
