// <auto-generated />
namespace DemoApplication.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class UserClaims : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(UserClaims));
        
        string IMigrationMetadata.Id
        {
            get { return "201303170554487_User Claims"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return Resources.GetString("Source"); }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}