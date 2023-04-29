IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [InterfaceErrorLogging] (
        [Timestamp] datetime NOT NULL,
        [Error Code] int NOT NULL,
        [Error Message] varchar(300) NULL
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [Vehicle] (
        [TagNumber] char(5) NOT NULL,
        [VehYear] numeric(4, 0) NOT NULL,
        [Make] varchar(30) NOT NULL,
        [Model] varchar(30) NOT NULL,
        [Color] varchar(30) NOT NULL,
        [VehicleType] varchar(10) NOT NULL,
        [Status] char(1) NOT NULL,
        [OwnerBudget] char(3) NOT NULL,
        [Mileage] numeric(6, 0) NULL,
        [OutOfServiceBegin] datetime NULL,
        [OutOfServiceEnd] datetime NULL,
        CONSTRAINT [PK_Vehicle] PRIMARY KEY ([TagNumber])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [VehicleAssignment] (
        [VehReqNo] int NOT NULL,
        [AssignNo] decimal(5, 0) NOT NULL,
        [AssignTagNo] char(5) NOT NULL,
        [AssignDepartDate] datetime NOT NULL,
        [AssignReturnDate] datetime NOT NULL,
        [Comments] varchar(50) NOT NULL,
        CONSTRAINT [PK_VehicleAssignment] PRIMARY KEY ([VehReqNo], [AssignNo])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [VehicleFunction] (
        [FUNC] char(4) NOT NULL,
        [FUNCTION_DESC] char(20) NULL,
        CONSTRAINT [PK_VehicleFunction] PRIMARY KEY ([FUNC])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [VehicleRequisition] (
        [VehReqNo] int NOT NULL,
        [VehReqDate] datetime NOT NULL,
        [Requestor] varchar(50) NOT NULL,
        [VehType] varchar(50) NOT NULL,
        [Destination] varchar(50) NOT NULL,
        [Duties] varchar(50) NOT NULL,
        [NoInParty] decimal(2, 0) NOT NULL,
        [ReqDivision] varchar(50) NOT NULL,
        [ReqSectionID] char(4) NOT NULL,
        [ReqBudget] char(3) NOT NULL,
        [ReqFunction] char(4) NOT NULL,
        [ReqJobNo] char(6) NOT NULL,
        [ReqFAP] char(11) NOT NULL,
        [ReqComments] varchar(50) NOT NULL,
        [ReqDepartDate] datetime NOT NULL,
        [ReqReturnDate] datetime NOT NULL,
        [Userid] char(8) NOT NULL,
        [VehReqStatus] char(1) NOT NULL,
        [NotificationDivHead] varchar(50) NOT NULL,
        [NotificationMan] varchar(50) NOT NULL,
        [EmailAddress] varchar(50) NULL,
        [LastChangeUserid] char(7) NOT NULL,
        CONSTRAINT [PK_VehicleRequisition] PRIMARY KEY ([VehReqNo])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE UNIQUE INDEX [IX_VehicleAssignment] ON [VehicleAssignment] ([VehReqNo]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    CREATE INDEX [NonClusteredIndex-20170815-094707] ON [VehicleAssignment] ([VehReqNo], [AssignNo], [Comments], [AssignTagNo], [AssignDepartDate], [AssignReturnDate]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221215174012_IdentityAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221215174012_IdentityAdded', N'3.1.32');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DROP TABLE [AspNetRoleClaims];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DROP TABLE [AspNetUserClaims];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DROP TABLE [AspNetUserLogins];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DROP TABLE [AspNetUserRoles];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DROP TABLE [AspNetUserTokens];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DROP TABLE [AspNetRoles];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DROP TABLE [AspNetUsers];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[VehicleRequisition]') AND [c].[name] = N'NotificationMan');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [VehicleRequisition] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [VehicleRequisition] ALTER COLUMN [NotificationMan] varchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[VehicleRequisition]') AND [c].[name] = N'NotificationDivHead');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [VehicleRequisition] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [VehicleRequisition] ALTER COLUMN [NotificationDivHead] varchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[VehicleRequisition]') AND [c].[name] = N'LastChangeUserid');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [VehicleRequisition] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [VehicleRequisition] ALTER COLUMN [LastChangeUserid] char(7) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    ALTER TABLE [VehicleRequisition] ADD [LastChangeDate] datetime NOT NULL DEFAULT '0001-01-01T00:00:00.000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    CREATE TABLE [vwEmployeeInfo] (
        [EMPLOYEE_NUMBER] varchar(9) NULL,
        [NAME_LAST] varchar(27) NULL,
        [FIRST_NAME] varchar(15) NULL,
        [SECTION_ID] varchar(4) NULL,
        [SectionDesc] varchar(25) NULL,
        [ITEM] varchar(4) NULL,
        [JOB_TITLE] varchar(30) NULL
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204259_AddedViewEmployeeInfo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230111204259_AddedViewEmployeeInfo', N'3.1.32');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204839_AddedViewEmployeeInfotry2')
BEGIN
    EXEC sp_rename N'[vwEmployeeInfo]', N'VwEmployeeInfos';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111204839_AddedViewEmployeeInfotry2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230111204839_AddedViewEmployeeInfotry2', N'3.1.32');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111222119_FixedEmployeeInfoScaffolding')
BEGIN
    DROP TABLE [VwEmployeeInfos];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230111222119_FixedEmployeeInfoScaffolding')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230111222119_FixedEmployeeInfoScaffolding', N'3.1.32');
END;

GO

