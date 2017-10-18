namespace UdemyASP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetUsers]
        ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'09c38ae5-aee2-4667-97c7-43dceded10e1', N'deagle67@hotmail.com', 0, N'AMwmtf4NZcK50HJqVkf6yFOgDjmrNl3QYA3ie1l0/fmLukUkeJJXFuOtcC92JZmXvA==', N'6c776ee6-8ac9-45e5-83bf-aada1c94ee8d', NULL, 0, 0, NULL, 1, 0, N'deagle67@hotmail.com')");
            Sql(@"INSERT INTO[dbo].[AspNetUsers]
        ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'72e10750-1388-46fb-b0d5-7393f8239373', N'guest@udemyasp2.net', 0, N'AJ+qrDvQuOZ2fnBqii9CU3asVb4iD/H3URrGmt7NMM6sNUmbvAOVdPnPju9Ix+/ezg==', N'0759a2bb-5c2c-42b7-8379-f8a52f050937', NULL, 0, 0, NULL, 1, 0, N'guest@udemyasp2.net')");
            Sql(@"INSERT INTO[dbo].[AspNetUsers]
        ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'b08bb39b-05be-4d49-8638-f0f0f62ed341', N'admin@udemyasp2.com', 0, N'ADO6jTElxK4bZWQ8PnBvuIDvCl873UbnbA8avn46LN/yZyD+lhIjJBgPZMlli/jm8A==', N'3c281a36-fb65-4c9f-87a4-639ef9474f6e', NULL, 0, 0, NULL, 1, 0, N'admin@udemyasp2.com')");


            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a903da35-e47c-46fe-ad9a-f51d2f7f24f8', N'CanManageMovies')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b08bb39b-05be-4d49-8638-f0f0f62ed341', N'a903da35-e47c-46fe-ad9a-f51d2f7f24f8')");
        }

    public override void Down()
        {
        }
    }
}
