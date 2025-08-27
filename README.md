# Introduction 
DEPLOYMENT TO PRODUCTION CHANGES ON SESTICKET
Full documentation available in this repository at ./SESTicket/docs
The 'Build and Test' section below is based on this documentation, which also provides screenshots of the process.

# Getting Started
Full documentation available in this repository at ./SESTicket/docs which includes the installation process and software dependencies.

# Build and Test
0.	Versioning changes in TFS

1.	Check the version of the app in the class clsSystemVersion.vb

2.	Deletes SESTicket folder located in path C:\SESTicket 

3.	Enter the following server \\colapp07\SESTicket\Release
 
4.	 Copy SESTicket_v7.1.0_COL.zip file 

5.	Paste the SESTicket_v7.1.0_COL.zip file into a new temporary folder (C:\Temp)

6.	Extract documents from the SESTicket_v7.1.0_COL.zip archive

7.	Copy the extracted SESTicket folder to disk C
 
8.	Open application located C:\SESTicket 

9.	Update app data
 
10.	Enter the location C:\SESTicket\data copy the files found in that location:

11.	Copy the files to the location C:\Temp\SESTicket\data        
12.	Open the SESTicket.accdb file located in the following path C:\Temp\SESTicket\data (db password in SESTicket.exe.config)
a.	Find VERSIONSYSTEM table
b.	Modify the VERSIONSYSTEM column
 
13.	Open SESTicketBaseData.accdb file located in the following path C:\Temp\SESTicket\data
a.	Find VERSIONSYSTEM table
b.	Modify the VERSIONSYSTEM column
 
14.	Open SESTicket project in Visual Studio 
a.	Open the class clsSystemVersion.vb and modify the version number
b.	Open the class AssemblyInfo.vb and modify the AssemblyVersion & AssemblyFileVersion

15.	Go to SESTicket app solution click on Build

16.	Go to the location where the source code is located, example C:\VSProjectsTfs\SESTicket\SESTicket\SESTicket\bin\Debug where the modified application code is located
a.	Select all files and delete
 
17.	Go to SESTicket app solution click on ReBuild

18.	Verify generated files in locations      
a.	C:\VSProjectsTfs\SESTicket\SESTicket\SESTicket\bin\Debug\Reports\docx
    1. CEM-CO-SOP-09-SCF-06-FinishOperation.docx
    2. CEM-CO-SOP-09-SCF-06-StartOperation.docx

b.	C:\VSProjectsTfs\SESTicket\SESTicket\SESTicket\bin\Debug\Reports\xlsx
    1. servevalecopetrol.xlsx
    2. ticketecopetrol.xlsx
    3. ticketFrontera.xlsx

19.	Open path C:\Temp\SESTicket\app
a.	Select and delete all files except the attach folder and the SESTicket.exe.config (XML) file.

20.	Enter Path C:\VSProjectsTfs\SESTicket\SESTicket\SESTicket\bin\Debug
a.	Copy files except SESTicket.exe.config (XML)
 
21.	Enter C:\Temp\SESTicket\app
 
22.	Generate Packaging from the SESTicket folder located in C:\Temp
      
a. Generate SESTicket.zip
 
23.	Reame SESTicket.Zip to exact same name from the previous packaging (SESTicket_v7.1.0_COL.zip)
 
a. Changing the Packaging Version Number by renaming the packaging file to SESTicket_v7.1.1_COL.zip

24.	Copy the SESTicket_v7.1.1_COL.zip file generated on the application server \\colapp07\SESTicket\Release
 
25.	Modify Packaging Version in the COLSQL01 Database

--Commit
update versionsystem 
SET VERSIONSYSTEM='7.1.1'
,RELEASEFILE='SESTicket_v7.1.1_COL.zip';

select * from versionsystem ;
select * from  [SESTICKET].[dbo].[USER] u where u.USERNAME='jdecou'

--Rollback:
update versionsystem 
SET VERSIONSYSTEM='7.1.0'
,RELEASEFILE='SESTicket_v7.1.0_COL.zip';

26. Below is an example of the logging shown while the application updates.


Starting the process... 20/11/2020 12:00:42 a. m.
Getting the Version Information...
Version: 7.1.1
Getting the Old Version Information...
Old Version: 7.1.0
Checking the requisites...
Checking Log path...
Checking Release path...
Checking Bkp path...
Deleting previosly files...
Getting the File...
Source: \\colapp07\SESTicket\Release\SESTicket_v7.1.1_COL.zip
Destination: C:\SESTicket\update\release
Error: The specified network name is no longer available.

End process... 20/11/2020 12:03:24 a. m.



Starting the process... 20/11/2020 12:27:42 a. m.
Getting the Version Information...
Version: 7.1.1
Getting the Old Version Information...
Old Version: 7.1.0
Checking the requisites...
Checking Log path...
Checking Release path...
Checking Bkp path...
Deleting previosly files...
Getting the File...
Source: \\colapp07\SESTicket\Release\SESTicket_v7.1.1_COL.zip
Destination: C:\SESTicket\update\release
Error: The operation completed successfully.

End process... 20/11/2020 12:31:22 a. m.
