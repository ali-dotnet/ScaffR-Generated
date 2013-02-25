namespace DemoApplication.Core.Configuration
{
    using System.Configuration;
    using Membership;

    public partial class CoreSection
    {
        [ConfigurationProperty("membership", IsRequired = true)]
        public MembershipElement Membership
        {
            get
            {
                return (MembershipElement)base["membership"];
            }
        }
    }
}