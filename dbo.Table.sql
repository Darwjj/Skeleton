CREATE TABLE [dbo].[tblStaff] (

    [StaffID]        INT          IDENTITY (1, 1) NOT NULL,

    [Staff_FullName] VARCHAR (30) NULL,

    [Staff_Gender]   VARCHAR (1)  NULL,

    [Staff_Role]     VARCHAR (25) NULL,

    [Staff_JoinDate] DATE         NULL,

    [Staff_Salary]   MONEY        NULL,

    PRIMARY KEY CLUSTERED ([StaffID] ASC)

);

 