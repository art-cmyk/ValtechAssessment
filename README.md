# Valtech Assessment

## How to launch Selenium hub and node:

1. On Windows machines:
    *  Copy the whole Selenium folder as it is into C: so that the path is C:/Selenium
    *  Double click "Launch Selenium 3 Hub.bat" to start the hub
    *  Double click "Launch Selenium 3 Custom Node v1.bat" to start the node

2. On Macs or Linux machines:
    * You can use the selenium-server-standalone.jar
    * Run the appropriate command to start the hub on port 4445 (else you need to change the config file to reflect the port you used)
    * Run the appropriate command to start the node. The -browser argument should contain the appropriate platform and should not contain any version information

## How to run the tests:
1. Tests are using NUnit are the testing framework.
2. Please find the App.config in Valtech.Website.UI.Tests project and set the value of "TestSettingsFile" key to the absolute path of "ValtechSettings.config" file which is in the same directory as App.config. For some reason, on my machine, the relative paths in App.config are not being honoured. So, just to be on the safe side, please set the value on your machine as well as I know that this will definitely work.
3. Run the tests as you would any other Nunit tests.
