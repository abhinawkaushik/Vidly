namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeeUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3711ddc8-5129-4ab4-a854-71d21fc46893', N'guest@vidly.com', 0, N'ALbjYagzdlqjqtQ8fTwEh53uFtaj1npmY55bA6bBKRZB/sj6JXuykBjQy4JNAHon8g==', N'45374147-dc1f-4783-89cd-906021e776b4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a9532aa2-63c8-4ffa-b6cb-91aa392dfc69', N'admin@vidly.com', 0, N'AJMqQ/qEDXqScVcj06ZkyjFDGEyWGK/GtnRWio86RSUWda/wWuYC5Fh56U+6GPeJQg==', N'f2a0c49e-edfe-4ed6-a6bd-a4c332e08286', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'730b5501-8922-402f-a325-15467cf5f065', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a9532aa2-63c8-4ffa-b6cb-91aa392dfc69', N'730b5501-8922-402f-a325-15467cf5f065')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
