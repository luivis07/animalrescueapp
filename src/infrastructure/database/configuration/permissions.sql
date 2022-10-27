-- EXECUTE IN animalrescue-db
--USE animalrescue-db
CREATE USER animalrescueadmin FOR LOGIN animalrescueadmin
EXEC sp_addrolemember N'db_ddladmin', N'animalrescueadmin'
EXEC sp_addrolemember N'db_datareader', N'animalrescueadmin'
EXEC sp_addrolemember N'db_datawriter', N'animalrescueadmin'