CREATE DATABASE QLXinViec;
GO

USE QLXinViec;
GO

CREATE TABLE Skill (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	[Name] VARCHAR(255) NOT NULL
);
GO

CREATE TABLE [Location] (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	[Name] VARCHAR(255) NOT NULL
);
GO

CREATE TABLE YearExperience (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	[Name] VARCHAR(255) NOT NULL
);
GO

--ACCOUNT
CREATE TABLE Account (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Email VARCHAR(255) NOT NULL UNIQUE,
	[Password] VARCHAR(255) NOT NULL,
	[Name] VARCHAR(255) NOT NULL,
	[Role] VARCHAR(20) NOT NULL,
	Avatar IMAGE,
);
GO

--USER
CREATE TABLE UserProfile (
	Id INT PRIMARY KEY,
	Title VARCHAR(255),
	PhoneNumber VARCHAR(20),
	DateOfBirth DATE,
	Gender VARCHAR(20) DEFAULT 'Male',
	[Address] TEXT,
	PersonalLink TEXT,
	AboutMe TEXT,

	FOREIGN KEY (Id) REFERENCES Account(Id)
);
GO

CREATE TABLE UserEducation (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	SchoolName VARCHAR(255) NOT NULL,
	Major VARCHAR(255) NOT NULL,
	[From] DATE NOT NULL,
	[To] DATE NOT NULL,
	Detail TEXT,
	UserId INT NOT NULL,

	FOREIGN KEY (UserId) REFERENCES UserProfile(Id)
);
GO

CREATE TABLE UserWorkExperience (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	JobTitle VARCHAR(255) NOT NULL,
	CompanyName VARCHAR(255) NOT NULL,
	[From] DATE NOT NULL,
	[To] DATE NOT NULL,
	UserId INT NOT NULL,

	FOREIGN KEY (UserId) REFERENCES UserProfile(Id)
);
GO

CREATE TABLE UserPersonalProject (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	ProjectName VARCHAR(255) NOT NULL,
	[From] DATE NOT NULL,
	[To] DATE NOT NULL,
	[Description] TEXT,
	UserId INT NOT NULL,

	FOREIGN KEY (UserId) REFERENCES UserProfile(Id)
);
GO

--COMPANY + JOB
CREATE TABLE CompanyProfile (
	Id INT PRIMARY KEY,
	PhoneNumber VARCHAR(20),
	[Address] TEXT,
	DateEstablish DATE,
	CompanySize INT,
	CompanyLink TEXT,
	Reason TEXT,
	Overview TEXT,
	TaxCode VARCHAR(20),
	BusinessLicense TEXT,

	FOREIGN KEY (Id) REFERENCES Account(Id)
);
GO

CREATE TABLE JobPost (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Title VARCHAR(255) NOT NULL,
	RecruitmentNumber INT DEFAULT 1,
	Salary INT NOT NULL,
	[Description] TEXT NOT NULL,
	Requirement TEXT,
	Prioritize TEXT,
	Benefit TEXT,
	PostDate DATE NOT NULL,
	ExpireDate DATE NOT NULL,
	[Address] TEXT,
	YearExperienceId INT NOT NULL,
	LocationId INT NOT NULL,
	CompanyId INT NOT NULL,
	
	FOREIGN KEY (LocationId) REFERENCES [Location](id),
	FOREIGN KEY (CompanyId) REFERENCES CompanyProfile(Id),
	FOREIGN KEY (YearExperienceId) REFERENCES YearExperience(Id)
);
GO

CREATE TABLE JobSkill (
	JobPostId INT NOT NULL,
	SkillId INT NOT NULL,

	FOREIGN KEY (JobPostId) REFERENCES JobPost(Id),
	FOREIGN KEY (SkillId) REFERENCES Skill(Id),
	PRIMARY KEY (JobPostId, SkillId)
);
GO

CREATE TABLE UserApplyJob (
	UserId INT NOT NULL,
	JobPostId INT NOT NULL,
	[Status] VARCHAR(50) NOT NULL,
	CoverLetter TEXT,
	AppliedAt DATE NOT NULL,
	CvAttachment TEXT,

	FOREIGN KEY (UserId) REFERENCES UserProfile(Id),
	FOREIGN KEY (JobPostId) REFERENCES JobPost(Id),
	PRIMARY KEY (UserId, JobPostId)
);
GO

CREATE TABLE UserSkill (
	UserId INT NOT NULL,
	SkillId INT NOT NULL,

	FOREIGN KEY (UserId) REFERENCES UserProfile(Id),
	FOREIGN KEY (SkillId) REFERENCES Skill(Id),
	PRIMARY KEY (UserId, SkillId)
);
GO

CREATE TABLE UserFollowJob(
	UserId INT NOT NULL,
	JobPostId INT NOT NULL,

	FOREIGN KEY (UserId) REFERENCES UserProfile(Id),
	FOREIGN KEY (JobPostId) REFERENCES JobPost(Id),
	PRIMARY KEY (UserID, JobPostId)
);
GO

CREATE TABLE [Following](
	FollowingId INT NOT NULL,
	FollowedId INT NOT NULL,

	FOREIGN KEY (FollowingId) REFERENCES Account(Id),
	FOREIGN KEY (FollowedId) REFERENCES Account(Id),
	PRIMARY KEY(FollowingId, FollowedId)
);
GO

--Social
CREATE TABLE SocialPost(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Title TEXT NOT NULL,
	Contents TEXT,
	PostDate DATE NOT NULL,
	AccountID INT NOT NULL,

	FOREIGN KEY (AccountID) REFERENCES Account(Id)
);
GO

CREATE TABLE SocialPostSkill(
	SocialPostId INT NOT NULL,
	SkillId INT NOT NULL,

	FOREIGN KEY (SocialPostId) REFERENCES SocialPost(Id),
	FOREIGN KEY (SkillId) REFERENCES Skill(Id),
	PRIMARY KEY (SocialPostId, SkillId)
);
GO

CREATE TABLE Mail(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	[FromId] INT NOT NULL,
	[ToId] INT NOT NULL,
	Title TEXT,
	Contents TEXT,
	AttachFile TEXT,
	SendDate DATE NOT NULL,

	FOREIGN KEY ([FromId]) REFERENCES Account(Id),
	FOREIGN KEY ([ToId]) REFERENCES Account(Id)
);
GO

CREATE TABLE CompanyImage(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	CompanyId INT NOT NULL,
	[ImageContent] IMAGE,

	FOREIGN KEY (CompanyId) REFERENCES CompanyProfile(Id)
);
GO
