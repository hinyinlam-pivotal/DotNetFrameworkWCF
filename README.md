# DotNetFrameworkWCF
WCF example in .NET framework 4.5 
Tested in PAS Windows 2012R2 and 2016 DiegoCell 

## What is WCF?
Please reference to this Windows Communication Framework:
https://docs.microsoft.com/en-us/dotnet/framework/wcf/whats-wcf

## Instruction to run:

### Step 1: 
Open this project in Visual Studio 2017 (Community version is ok)

### Step 2:
Try to run it locally:

![RunWithIIS](doc/images/run_with_iis.jpg?raw=true "Run with IIS Express")



You should be able to see this application has no index file:


![ListAllFiles](doc/images/list_all_file_iis.jpg?raw=true "List all file in an IIS")

### Step 3:
Click on the FengShui.svc link:

![HighlightFengShui.svc](doc/images/feng_Shui_link.jpg?raw=true "FengShuiLink")


You should be able to see this:

![FengShuiService](doc/images/feng_Shui_link.jpg?raw=true "FengShuiService")


### Step 4:
In your Visual Studio 2017, there is a program called: 

<PATH_TO_YOUR_VS2017_INSTALL>\VisualStudio2017\Common7\IDE\WcfTestClient.exe

![WCFTestClient](doc/images/wcftestclient.jpg?raw=true "WCFTestClient GUI")

### Step 5:
Add WCF service to WCFTestClient:

![AddingWCFToRefresh](doc/images/adding_wcf_to_refresh.jpg?raw=true "WCFTestClient Add Service")

If you see this service listing, you are success!

![WCFAccessSuccess](doc/images/wcf_access_success.jpg?raw=true "WCFTestClient Add Success")


# How to run in Pivotal Application Service?

### Prerequisite

### Step 1:
`cf push dotnetframeworkwcf-win2012R2 -s windows2012R2 -b hwc_buildpack -p . -m 1G`
`cf push dotnetframeworkwcf-win2016   -s windows2016   -b hwc_buildpack -p . -m 1G`

