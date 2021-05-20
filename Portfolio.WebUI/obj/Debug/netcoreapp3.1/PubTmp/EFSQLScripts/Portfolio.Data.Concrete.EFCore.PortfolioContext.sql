IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [Categories] (
        [CategoryId] int NOT NULL IDENTITY,
        [CategoryName] nvarchar(max) NULL,
        [CType] int NOT NULL,
        [Filter] nvarchar(max) NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [Contacts] (
        [ContactId] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NOT NULL,
        [Mail] nvarchar(max) NOT NULL,
        [Title] nvarchar(30) NOT NULL,
        [Text] nvarchar(500) NOT NULL,
        [isRead] bit NOT NULL,
        CONSTRAINT [PK_Contacts] PRIMARY KEY ([ContactId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [Footers] (
        [FooterId] int NOT NULL IDENTITY,
        [SocialMediaName] nvarchar(max) NULL,
        [Link] nvarchar(max) NULL,
        [Icon] nvarchar(max) NULL,
        [Order] int NOT NULL,
        CONSTRAINT [PK_Footers] PRIMARY KEY ([FooterId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [MenuItems] (
        [MenuItemId] int NOT NULL IDENTITY,
        [MenuItemName] nvarchar(max) NULL,
        [Link] nvarchar(max) NULL,
        CONSTRAINT [PK_MenuItems] PRIMARY KEY ([MenuItemId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [Projects] (
        [ProjectId] int NOT NULL IDENTITY,
        [CoverImage] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [isDone] bit NOT NULL,
        CONSTRAINT [PK_Projects] PRIMARY KEY ([ProjectId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [SubMenus] (
        [SubMenuId] int NOT NULL IDENTITY,
        [SubMenuName] nvarchar(max) NULL,
        [Link] nvarchar(max) NULL,
        [MenuItemId] int NOT NULL,
        CONSTRAINT [PK_SubMenus] PRIMARY KEY ([SubMenuId]),
        CONSTRAINT [FK_SubMenus_MenuItems_MenuItemId] FOREIGN KEY ([MenuItemId]) REFERENCES [MenuItems] ([MenuItemId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [CategoryProject] (
        [CategoriesCategoryId] int NOT NULL,
        [ProjectsProjectId] int NOT NULL,
        CONSTRAINT [PK_CategoryProject] PRIMARY KEY ([CategoriesCategoryId], [ProjectsProjectId]),
        CONSTRAINT [FK_CategoryProject_Categories_CategoriesCategoryId] FOREIGN KEY ([CategoriesCategoryId]) REFERENCES [Categories] ([CategoryId]) ON DELETE CASCADE,
        CONSTRAINT [FK_CategoryProject_Projects_ProjectsProjectId] FOREIGN KEY ([ProjectsProjectId]) REFERENCES [Projects] ([ProjectId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [Images] (
        [ImageId] int NOT NULL IDENTITY,
        [ImageName] nvarchar(max) NULL,
        [FullPath] nvarchar(max) NULL,
        [ProjectId] int NULL,
        CONSTRAINT [PK_Images] PRIMARY KEY ([ImageId]),
        CONSTRAINT [FK_Images_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([ProjectId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [Services] (
        [ServiceId] int NOT NULL IDENTITY,
        [ImageId] int NOT NULL,
        [Title] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [isHome] bit NOT NULL,
        CONSTRAINT [PK_Services] PRIMARY KEY ([ServiceId]),
        CONSTRAINT [FK_Services_Images_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [Images] ([ImageId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [Sliders] (
        [SliderId] int NOT NULL IDENTITY,
        [ImageId] int NOT NULL,
        [isHome] bit NOT NULL,
        CONSTRAINT [PK_Sliders] PRIMARY KEY ([SliderId]),
        CONSTRAINT [FK_Sliders_Images_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [Images] ([ImageId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE TABLE [Testimonials] (
        [TestimonialId] int NOT NULL IDENTITY,
        [ImageId] int NOT NULL,
        [Title] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [isHome] bit NOT NULL,
        CONSTRAINT [PK_Testimonials] PRIMARY KEY ([TestimonialId]),
        CONSTRAINT [FK_Testimonials_Images_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [Images] ([ImageId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE INDEX [IX_CategoryProject_ProjectsProjectId] ON [CategoryProject] ([ProjectsProjectId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE INDEX [IX_Images_ProjectId] ON [Images] ([ProjectId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_Services_ImageId] ON [Services] ([ImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_Sliders_ImageId] ON [Sliders] ([ImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE INDEX [IX_SubMenus_MenuItemId] ON [SubMenus] ([MenuItemId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_Testimonials_ImageId] ON [Testimonials] ([ImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210503123710_AllCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210503123710_AllCreate', N'5.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Testimonials]') AND [c].[name] = N'Title');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Testimonials] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Testimonials] ALTER COLUMN [Title] nvarchar(20) NOT NULL;
    ALTER TABLE [Testimonials] ADD DEFAULT N'' FOR [Title];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Testimonials]') AND [c].[name] = N'Text');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Testimonials] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Testimonials] ALTER COLUMN [Text] nvarchar(150) NOT NULL;
    ALTER TABLE [Testimonials] ADD DEFAULT N'' FOR [Text];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubMenus]') AND [c].[name] = N'SubMenuName');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [SubMenus] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [SubMenus] ALTER COLUMN [SubMenuName] nvarchar(20) NOT NULL;
    ALTER TABLE [SubMenus] ADD DEFAULT N'' FOR [SubMenuName];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SubMenus]') AND [c].[name] = N'Link');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [SubMenus] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [SubMenus] ALTER COLUMN [Link] nvarchar(50) NOT NULL;
    ALTER TABLE [SubMenus] ADD DEFAULT N'' FOR [Link];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Services]') AND [c].[name] = N'Title');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Services] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Services] ALTER COLUMN [Title] nvarchar(20) NOT NULL;
    ALTER TABLE [Services] ADD DEFAULT N'' FOR [Title];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Services]') AND [c].[name] = N'Text');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Services] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Services] ALTER COLUMN [Text] nvarchar(150) NOT NULL;
    ALTER TABLE [Services] ADD DEFAULT N'' FOR [Text];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Projects]') AND [c].[name] = N'Title');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Projects] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Projects] ALTER COLUMN [Title] nvarchar(30) NOT NULL;
    ALTER TABLE [Projects] ADD DEFAULT N'' FOR [Title];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Projects]') AND [c].[name] = N'Text');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Projects] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Projects] ALTER COLUMN [Text] nvarchar(750) NOT NULL;
    ALTER TABLE [Projects] ADD DEFAULT N'' FOR [Text];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MenuItems]') AND [c].[name] = N'MenuItemName');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [MenuItems] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [MenuItems] ALTER COLUMN [MenuItemName] nvarchar(20) NOT NULL;
    ALTER TABLE [MenuItems] ADD DEFAULT N'' FOR [MenuItemName];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MenuItems]') AND [c].[name] = N'Link');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [MenuItems] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [MenuItems] ALTER COLUMN [Link] nvarchar(50) NOT NULL;
    ALTER TABLE [MenuItems] ADD DEFAULT N'' FOR [Link];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Footers]') AND [c].[name] = N'SocialMediaName');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Footers] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [Footers] ALTER COLUMN [SocialMediaName] nvarchar(20) NOT NULL;
    ALTER TABLE [Footers] ADD DEFAULT N'' FOR [SocialMediaName];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Footers]') AND [c].[name] = N'Link');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Footers] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [Footers] ALTER COLUMN [Link] nvarchar(100) NOT NULL;
    ALTER TABLE [Footers] ADD DEFAULT N'' FOR [Link];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Contacts]') AND [c].[name] = N'Title');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Contacts] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [Contacts] ALTER COLUMN [Title] nvarchar(50) NOT NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Contacts]') AND [c].[name] = N'Text');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Contacts] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [Contacts] ALTER COLUMN [Text] nvarchar(750) NOT NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var14 sysname;
    SELECT @var14 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Categories]') AND [c].[name] = N'Filter');
    IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Categories] DROP CONSTRAINT [' + @var14 + '];');
    ALTER TABLE [Categories] ALTER COLUMN [Filter] nvarchar(8) NOT NULL;
    ALTER TABLE [Categories] ADD DEFAULT N'' FOR [Filter];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    DECLARE @var15 sysname;
    SELECT @var15 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Categories]') AND [c].[name] = N'CategoryName');
    IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Categories] DROP CONSTRAINT [' + @var15 + '];');
    ALTER TABLE [Categories] ALTER COLUMN [CategoryName] nvarchar(20) NOT NULL;
    ALTER TABLE [Categories] ADD DEFAULT N'' FOR [CategoryName];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210510151726_AnnotationCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210510151726_AnnotationCreate', N'5.0.2');
END;
GO

COMMIT;
GO

