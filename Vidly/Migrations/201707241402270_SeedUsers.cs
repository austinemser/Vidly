namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1a031343-41ea-48f2-b865-f4aa694a782a', N'guest@vidly.com', 0, N'AN5+Z+ZqscovRXrhBq3lITjzGDsk3rBO/JX1RP7Y7JMlZ1uZgo0wgAc1TIeNey+6fQ==', N'56b652bd-0d77-487a-858c-88904f1b5683', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1fc1a278-a5db-451b-926b-05e9221859cf', N'admin@vidly.com', 0, N'AG8hbJVkqAOUKjxKS4OXKp6xZX4RQWyep/n2XQZRLKP46iKXam7pTpSkCSAFL0ZVfA==', N'cfe53007-6d43-4b27-8568-dc7ea671f238', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd1d17824-1db1-4f5d-85fd-47f8e573f32d', N'CanManageMovies') 
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1fc1a278-a5db-451b-926b-05e9221859cf', N'd1d17824-1db1-4f5d-85fd-47f8e573f32d')           
            ");
        }
        
        public override void Down()
        {
        }
    }
}
